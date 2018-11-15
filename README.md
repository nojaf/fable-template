# Minimal fable template

## Install

> dotnet new -i Fable.Template.nojaf

## Create

> dotnet new fable-nojaf -n myApp

## Install dependencies

> cd myApp
> yarn install

Installs node and dotnet dependencies.

## Develop

> cd src
> dotnet fable yarn-run start

Starts Fable daemon (compile F# to js), bundles and serves with [parcel](https://parceljs.org/) and watches unit tests with [Jest](https://jestjs.io).

Open [http://localhost:1234](http://localhost:1234) to access the dev server.