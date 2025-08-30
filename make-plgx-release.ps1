#  Copyright (C) 2018-2020 iSnackyCracky, (C) 2025 charlamagnethadog
#
#  This file is part of KeePassRDP-Lite.
#
#  KeePassRDP-Lite is free software: you can redistribute it and/or modify
#  it under the terms of the GNU General Public License as published by
#  the Free Software Foundation, either version 3 of the License, or
#  (at your option) any later version.
#
#  KeePassRDP-Lite is distributed in the hope that it will be useful,
#  but WITHOUT ANY WARRANTY; without even the implied warranty of
#  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
#  GNU General Public License for more details.
#
#  You should have received a copy of the GNU General Public License
#  along with KeePassRDP-Lite.  If not, see <http://www.gnu.org/licenses/>.

$VersionFilePath = ".\KeePassRDP-Lite.ver"
[System.Version]$KeePassRDPver = (Get-Content "KeePassRDP-Lite\Properties\AssemblyInfo.cs" | Select-String -Pattern "[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+")[0].Matches.Value
write-output "`nBuilding PLGX release for KeePassRDP-Lite $KeePassRDPver" 

write-output "Preparing build folder..."

#clear destination folder
$BuildOut = ".\KeePassRDP-Lite\bin\Release-PLGX"
Remove-Item -Path $BuildOut\* -Recurse

# copy only files required for building plgx
$SourceIn = ".\KeePassRDP-Lite"
$SourceOut = ".\KeePassRDP-Lite\bin\Release-PLGX\KeePassRDP-Lite"
New-Item -ItemType Directory -Force -Path $SourceOut > $null # destination folder must exist
Copy-Item $SourceIn\* $SourceOut -Exclude @("bin","obj") -Recurse

write-output "Building plgx..."
Start-Process -NoNewWindow -FilePath .\build\exe\KeePass.exe -ArgumentList "--plgx-create", "$SourceOut" -Wait

write-output "Building release zip (containing plgx)...."
$zipIn = "$SourceOut.plgx"
$zipOut = ("$SourceOut" + "_v$( $KeePassRDPver.Major ).$( $KeePassRDPver.Minor ).$( $KeePassRDPver.Build ).zip")

if (Test-Path -Path $zipIn -PathType Leaf) {
    # create zip, since we're specifying a full path to 7z.exe, need to explicitly set the working directory
    Start-Process -NoNewWindow -WorkingDirectory $pwd -FilePath "C:\Program Files\7-Zip\7z.exe" -ArgumentList "a", "-bso0", "$zipOut", "$zipIn" -Wait
}

write-output "Updating version file..."
# Create/update KeePassRDP-Lite.ver with current version for KeePass plugin update checking
":" |Out-File -FilePath $VersionFilePath -Encoding utf8
"KeePassRDP-Lite:$( $KeePassRDPver.ToString() )" |Out-File -FilePath $VersionFilePath -Encoding utf8 -Append
":" |Out-File -FilePath $VersionFilePath -Encoding utf8 -Append

write-output "make complete."