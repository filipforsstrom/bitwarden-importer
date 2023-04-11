# bitwarden-importer

CLI tool for solving the "[Maximum collections error](https://bitwarden.com/help/import-from-lastpass/#maximum-collections-error)" when importing LastPass data to Bitwarden.

## Usage

1. Install [dotnet 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
2. git clone or download this repository
3. run ```dotnet run [path to lastpass_export.csv]```

### Example

Move your lastpass_export.csv file to the root directory of this repository and run this command:

```terminal
dotnet run lastpass_export.csv
```
