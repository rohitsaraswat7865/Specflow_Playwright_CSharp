# Specflow_Playwright_C#_BaseFramework

1) Open CMD in project root folder i.e. directory within folder "Playwright_BaseFramework" which has the Playwright_BaseFramework.sln (the solution) file.

Run following commands in CMD -> 

2) dotnet clean
3) dotnet build --property WarningLevel=0

4) Install playwright with dependencies
   4.1) Open powershell in Playwright_BaseFramework\bin\Debug\net6.0\ , then run powershell commmand
   4.2)  .\playwright.ps1 install

3) dotnet test --filter TestCategory=regression 


   
