# TSMSISrv_poc

## Description

The SessionEnv service, which is installed by default on Windows, contains a DLL hijack. When a user with administrative privilege can restart this service they could utilize it for lateral movement.

This C# POC code leverages the called functions of the TSMSISrv.dll by putting malicious logic within StartComponent.

## Build Process

Ensure you have UnmanagedExports installed and are building for your target architecture. Then, you can simply build the release version of the project.

## Execution Instructions

1. `sc.exe \\COMPUTER stop SessionEnv`
2. `copy TSMSISrv.dll to C:\Windows\System32\TSMSISrv.dll`
3. `sc.exe \\COMPUTER start SessionEnv`

Execution should have occurred adding a new user "demo".

## Blog Details
https://posts.specterops.io/lateral-movement-scm-and-dll-hijacking-primer-d2f61e8ab992
