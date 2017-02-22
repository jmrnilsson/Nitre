#!/usr/bin/env powershell

[CmdletBinding()]

Param([Parameter(Mandatory=$False,Position=1)] [string]$Command)
$initialPath = $PWD
$itertoolsPath = Join-Path -Path $initialPath -ChildPath "Itertools"
$itertoolsTestPath = Join-Path -Path $initialPath -ChildPath "Itertools.Test"

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
    rm -rf ./bin/
    rm -rf ./obj/
    rm -rf ./packages/

    Write-Output $("Entering '{0}'.." -f $itertoolsTestPath)
    Set-Location $itertoolsTestPath
    rm -rf ./bin/
    rm -rf ./obj/
    rm -rf ./packages/

    Write-Output $("Entering '{0}'.." -f $initialPath)
    Set-Location $initialPath
    Exit 0;
}

If (New-Target ./Itertools/project.json ./Itertools/project.lock.json)
{
    $(Set-Location Itertools; dotnet restore)
}
Else
{
    Write-Output "Skipping ./Itertools/project.json..."
}

If (New-Target ./Itertools.Test/project.json ./Itertools.Test/project.lock.json)
{
    $(Set-Location $itertoolsTestPath; dotnet restore)
}
Else
{
    Write-Output "Skipping ./Itertools.Test/project.json..."
}


If ($Command -imatch "test" -or $Command -imatch $DefaultCommand)
{
    Set-Location $itertoolsTestPath
    $(dotnet build)
}

If ($Command -imatch "build" -or $Command -imatch $DefaultCommand)
{
    Set-Location $itertoolsPath
    $(dotnet build)
    Set-Location $itertoolsTestPath
    $(dotnet build)
}

Write-Output $("Entering '{0}'.." -f $initialPath)
Set-Location $initialPath
Write-Output "Done!"
