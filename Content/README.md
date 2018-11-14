# Fable template (nojaf)

## Paket

Requires local installation of [Paket](https://www.nuget.org/packages/Paket/) if still needed.
> dotnet tool install  --tool-path \".paket\" Paket --add-source https://api.nuget.org/v3/index.json

## Install dependencies:

`npm install` or `yarn install`. The `postinstall` will run `dotnet restore` and trigger paket to download the .NET dependencies.

## Development

Open a prompt in the `src` folder.
Execute `dotnet restore` so you can run `dotnet fable`.

Start dev server with `dotnet fable npm-run start`. 

This launches Fable-daemon and compiles files in `src\App.fsproj` to the `output` folder.

It also starts [parcel](https://parceljs.org) to serve all files located in the output folder and [jest](https://jestjs.io/) to run unit tests.