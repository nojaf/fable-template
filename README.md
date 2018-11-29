# Minimal fable template

<img src="screenshot.png" />

## Install

> dotnet new -i Fable.Template.nojaf

## Create

> dotnet new fable-nojaf -n myApp

## Install dependencies

> cd myApp

> yarn install

Installs node and dotnet dependencies.

## Develop

> yarn start

Starts Fable (compile F# to js) and [parcel](https://parceljs.org/) (bundles and serves files).

Open [http://localhost:8080](http://localhost:8080) to access the dev server.

## Unit test

> yarn test

Or

> yarn test:watch

Calls `jest` to run the tests in the compiled files. (Run `yarn compile` first if no JS files are present in `output` folder).

Most likely you want to run tests and see something in your browser.
Run `yarn start` in one console and `yarn test:watch` in another.
This is handy to see both Fable compilation errors as well as unit test issues at the same time.

## Clean

> yarn clean

Remove caches and compiled JS