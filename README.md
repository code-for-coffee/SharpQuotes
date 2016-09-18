# SharpQuotes
Mono .NET MVC 5.x application boilerplate

## Tests

[![Build Status](https://travis-ci.org/code-for-coffee/SharpQuotes.svg?branch=master)](https://travis-ci.org/code-for-coffee/SharpQuotes)

All test are written using the NUnit Library.

## Deployment on Heroku

1. Create a `Procfile` that contains the following script: `mono ProjectName.exe`
2. Specify the Heroku Buildpack

```bash
heroku buildpacks:set https://github.com/AdamBurgess/heroku-buildpack-mono
Buildpack set. Next release on _yourappnamehere_ will use https://github.com/AdamBurgess/heroku-buildpack-mono.
```

3. `git push heroku master` to go live!