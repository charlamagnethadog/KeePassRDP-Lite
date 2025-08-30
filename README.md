[<img alt="latest release" src="https://img.shields.io/github/v/release/charlamagnethadog/KeePassRDP-Lite?style=flat-square">](https://github.com/charlamagnethadog/KeePassRDP-Lite/releases/latest) <img alt="downloads (all releases)" src="https://img.shields.io/github/downloads/charlamagnethadog/KeePassRDP-Lite/total?style=flat-square"> [<img alt="GitHub" src="https://img.shields.io/github/license/charlamagnethadog/KeePassRDP-Lite?style=flat-square">](https://github.com/charlamagnethadog/KeePassRDP-Lite/blob/master/COPYING)

# KeePassRDP-Lite
## Overview
KeePassRDP-Lite is a plugin for KeePass 2.x which adds multiple options to connect via RDP to the URL of an entry.  This project was forked from iSnackyCracky's [KeePassRDP](https://github.com/iSnackyCracky/KeePassRDP) (around version 1.13.2) and renamed to KeePassRDP-Lite.

## Installation
1. Download the zip file from the newest [release](https://github.com/charlamagnethadog/KeePassRDP-Lite/releases)
2. Unzip and copy the KeePassRDP-Lite.plgx file to your KeePass plugins folder.

## Usage
To connect via RDP to a machine, select the entry containing the IP-address or hostname, right-click and select *KeePassRDP-Lite* \> *Open RDP connection* (or just press <kbd>CTRL</kbd> + <kbd>M</kbd>).

To use the other connection options, just select the corresponding entries in the context-menu.

## Features
- Connect to host via RDP
- Connect to host via RDP admin session (`mstsc.exe /admin` parameter)
- Customize `mstsc.exe` parameters (`/f`, `/span`, `/multimon`, `/w`, `/h`)
- Gather and show possible Windows or domain credentials when the connection entry is inside a group called "RDP" (see below for details)


### Credentials Group / folder
The intent is for all systems (i.e. servers, workstations) to be located in a single folder within the KeePass database.  There can be additional subfolders.  There should be a separate high-level folder that contains credentials.  This can also contain subfolders.

Under KeePassRDP-Lite Options, go to the CredPicker options tab, click Set Cred Group and select the credential folder.

When you start the process to connect via KeePassRDP-Lite, a list of credentials will appear.  When you select the credentials, those will be used to connect to the RDP destination.

## How it works
The plugin basically just calls the default `mstsc.exe` with the `/v:<address>` (and optionally other) parameter(s) to connect.

If you choose to open a connection *with credentials* it stores the credentials into the Windows Credential Manager ("Vault") for usage by the `mstsc.exe` process.

These Credentials then get removed again after about 10 seconds.

## Development
When developing changes to this project, unzip a copy of [KeePass 2.x Portable](https://keepass.info/download.html) in the folder ./build/exe.  An assembly reference to this exe is used to resolve KeePass functions, copied to the build output folder and used for testing as well as to build the release PLGX.

My debug configuration contains the full path to the debug executable under Start external program.  The arguments then contain a reference to a test database and the test password.  This makes debugging much faster.  A command line could look something like this:

```
c:\code\KeePassRDP-Lite\KeePassRDP-Lite\bin\Debug\KeePass.exe "c:\code\KeePassRDP-Lite\build\kdbx\test.kdbx" -pw:password123
```

## Third-party Software
This plugin uses the following third-party libraries:
- the "ListView" wrapper [**ObjectListView**](http://objectlistview.sourceforge.net/cs/index.html) by Phillip Piper
- the "Windows Credential Management API" wrapper [**CredentialManagement**](https://github.com/ilyalozovyy/credentialmanagement) by [iLya Lozovyy](https://github.com/ilyalozovyy)
