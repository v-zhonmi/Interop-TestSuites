@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_WEBSS.S05_OperationsOnObjectId.MSWEBSS_S05_TC03_GetObjectIdFromUrl_NoListOrListItemUrl /testcontainer:..\..\MS-WEBSS\TestSuite\bin\Debug\MS-WEBSS_TestSuite.dll /runconfig:..\..\MS-WEBSS\MS-WEBSS.testsettings /unique
pause