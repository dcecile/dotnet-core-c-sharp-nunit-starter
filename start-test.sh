#!/bin/sh
 chokidar Source/ Tests/ --command "clear && dotnet test Tests/" --ignore '**/bin' --ignore '**/obj' --initial
