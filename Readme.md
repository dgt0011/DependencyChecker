# NuGet Dependency Checker

[![Build status](https://dev.azure.com/webdude/DependencyChecker/_apis/build/status/DependencyChecker)](https://dev.azure.com/webdude/DependencyChecker/_build/latest?definitionId=22)

Simple Tool for checking NuGet Dependencies and publish a report as build artifact. The results will be added to a new build tab and can be saved as build artifact. *(no dashboard widget yet, but i will work on it!)*.

**Feel free to submit future requests as issues!**

## Configuration
![Overview](https://raw.githubusercontent.com/chwebdude/DependencyChecker/master/images/overview.jpg)

## Build Result Tab
![Build Result Tab](https://raw.githubusercontent.com/chwebdude/DependencyChecker/master/images/reportTab.png)

## Report
![Report](https://raw.githubusercontent.com/chwebdude/DependencyChecker/master/images/report.jpg)

## How to start

First add the root directory of the project as Searchpath. This is usually `$(Build.SourcesDirectory)`. If you also check the Search Recursive box all packages.config files will be analyzed.
Now you can say if you want to create a badge and if to create a report. The destination or the reportfile is very important. By default it will be created in the `$(Build.ArtifactStagingDirectory)` directory. Another build tasks has to handle this file. Ex. copy it to a webserver. Depending on your infrastructure you can also do this directly by `\\yourserver\yourshare\dependencies.html`. Just do the same with the badge path.

## Options

### Search Path
Path to check for the packages.config files.

### Search Recursive
Search subdirectories for the packages files.

### Include Prerelease
Include prerelease packages for search?

### Custom NuGet config file
Define your custom NuGet config which has additional sources.

### Create Badge
Create a badge using [DotBadge](https://github.com/rebornix/DotBadge).

### Create Badge per project
If selected, a badge will be created for every single project found. If not selected, the information of all projects will be aggregated and "the worst" will be generated.

### Badge Path
Where to save the badge and its name. (only available if only one badge needs to be generated)

### Badges Directory Path
Path of the directory where the badges should be generated (only available if multiple badges should be generated)

### Style
The style of the badge.

### Create Report
Create a report of the packages.

### Report Path
Location and name where to save report.


## Thanks
Following open source libraries are used for this little project. Thank you for your great work!
* [CommandLineParser](https://github.com/commandlineparser/commandline)
* [DotBadge](https://github.com/rebornix/DotBadge)
* [NuGet](https://github.com/NuGet/Home)
* [Stubble](https://github.com/stubbleorg/stubble)