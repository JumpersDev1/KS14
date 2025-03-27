@echo off
python ./soundartloader.py
dotnet run --project Content.Server --configuration Release --property:TieredPGO=true,TieredCompilationQuickJit=true,PublishReadyToRun=false
pause
