#!/bin/sh

set -e # Exit early if any commands fail

(
  cd "$(dirname "$0")" # Ensure compile steps are run within the repository directory
  dotnet build --configuration Release --output /tmp/codecrafters-build-redis-csharp codecrafters-redis.csproj
)

# Copied from .codecrafters/run.sh
#
# - Edit this to change how your program runs locally
# - Edit .codecrafters/run.sh to change how your program runs remotely
exec /tmp/codecrafters-build-redis-csharp/codecrafters-redis "$@"
