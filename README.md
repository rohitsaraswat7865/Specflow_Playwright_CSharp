# Playwright Base Framework

This project is a base automation framework using [Playwright](https://playwright.dev/dotnet/) and [SpecFlow](https://specflow.org/) for end-to-end testing of web applications in C#.

## Features
- SpecFlow for BDD-style test scenarios
- Playwright for browser automation
- Page Object Model structure
- Example feature: SauceDemo

## Project Structure
- `Features/` - Contains feature files and generated code
- `StepDefinitions/` - Step definition classes for SpecFlow
- `Support/` - Page objects and support files
- `bin/`, `obj/` - Build output directories
- `Playwright_BaseFramework.csproj` - Project file

## Getting Started
1. **Install dependencies**
   - .NET 6 SDK or later
   - Playwright: `dotnet add package Microsoft.Playwright`
   - SpecFlow: `dotnet add package SpecFlow`
   - SpecFlow+Runner: `dotnet add package SpecFlow.Plus.Runner`
2. **Restore NuGet packages**
   ```powershell
   dotnet restore
   ```
3. **Run Playwright install** (to download browser binaries)
   ```powershell
   pwsh bin\Debug\net6.0\playwright.ps1 install
   ```
4. **Run tests**
   ```powershell
   dotnet test
   ```

## Writing Tests
- Add new feature files in `Features/`
- Implement step definitions in `StepDefinitions/`
- Use page objects from `Support/`

## Useful Links
- [Playwright for .NET Documentation](https://playwright.dev/dotnet/docs/intro)
- [SpecFlow Documentation](https://docs.specflow.org/projects/specflow/en/latest/)

## License
MIT
