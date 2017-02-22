#!/usr/bin/env powershell

[CmdletBinding()]

Param([Parameter(Mandatory=$False,Position=1)] [string]$Command)
$initialPath = $PWD
$itertoolsPath = Join-Path -Path $initialPath -ChildPath "Itertools"
$itertoolsProjectPath = Join-Path -Path $itertoolsPath -ChildPath "project.json"
$itertoolsProjectLockPath = Join-Path -Path $itertoolsPath -ChildPath "project.lock.json"
$itertoolsTestPath = Join-Path -Path $initialPath -ChildPath "Itertools.Test"
$itertoolsTestProjectPath = Join-Path -Path $itertoolsTestPath -ChildPath "project.json"
$itertoolsTestProjectLockPath = Join-Path -Path $itertoolsTestPath -ChildPath "project.lock.json"


$DefaultCommand = "default"
$Command = If ($Command) { $Command } Else { $DefaultCommand }
Write-Output "Make targets ($Command)"

Function New-Target
{
    Param([string]$Source, [string]$Target)

    $Modified = If (Test-Path $Target)
    {
        ((Get-Item $Target).LastWriteTime).Ticks
    }
    Else
    {
        0
    }

    Return ((Get-Item $Source).LastWriteTime).Ticks -gt $Modified
}

If ($Command -imatch "clean")
{
    Write-Output $("Entering '{0}'.." -f $itertoolsPath)
    Set-Location $itertoolsPath

    Write-Output $("Clearing 'bin', 'obj', 'packages'..")
    rm -rf ./bin/
    rm -rf ./obj/
    rm -rf ./packages/

    Write-Output $("Entering '{0}'.." -f $itertoolsTestPath)
    Set-Location $itertoolsTestPath
    Write-Output $("Clearing 'bin', 'obj', 'packages'..")
    rm -rf ./bin/
    rm -rf ./obj/
    rm -rf ./packages/
}
ElseIf ($Command -imatch "build" -or $Command -imatch $DefaultCommand)
{
    Set-Location $itertoolsPath
    $(dotnet build)
    Set-Location $itertoolsTestPath
    $(dotnet build)
}
ElseIf ($Command -imatch "run")
{
    Set-Location $itertoolsPath
    $(dotnet run)
}
If ($Command -imatch "test" -or $Command -imatch $DefaultCommand)
{
    Set-Location $itertoolsTestPath
    $(dotnet test)
}
If ($Command -imatch $DefaultCommand)
{
    If (New-Target $itertoolsProjectPath $itertoolsProjectLockPath)
    {
        Set-Location $itertoolsPath
        $(dotnet restore)
    }
    Else
    {
        Write-Output $("Skipping {0}..." -f $itertoolsProjectPath)
    }

    If (New-Target $itertoolsTestProjectPath $itertoolsTestProjectLockPath)
    {
        Set-Location $itertoolsTestPath
        $(dotnet restore)
    }
    Else
    {
        Write-Output $("Skipping {0}..." -f $itertoolsTestProjectPath)
    }
}

Write-Output $("Entering '{0}'.." -f $initialPath)
Set-Location $initialPath
Write-Output "Done!"
