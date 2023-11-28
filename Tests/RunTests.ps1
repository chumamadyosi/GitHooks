param (
    [string]$C:\Users\ChumaM\source\repos\GitHooks\Tests\bin\Debug\net8.0\Tests.dll
)

# Run xUnit tests
dotnet test $C:\Users\ChumaM\source\repos\GitHooks\Tests\bin\Debug\net8.0\Tests.dll

# Get the exit code from the test command
$exitCode = $LASTEXITCODE

# Exit with the test command's exit code
exit $exitCode