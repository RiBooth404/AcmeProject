# <h1>AcmeProject</h1>
## <h2><u>Introduction</u></h2>
### Acme project it's a Solution built on C# to find how often employees have coincided in the office.
## <h2><u>About</u></h2>
### Acme project was built as a console application following a simplified 3 layers architechture, since adding more steps just would hinder the process of the program.
### This program only uses  4 classes as main structure;
### -Main class as fundamental base for this program.
### -Employee class as model for managing employees data in easier way.
### -Wrapper class to transform strings to Employee instances.
### -Flag enum class to cross days using only bytes taking advantage of operators <i>"|"</i> and <i>"&"</i> with bytes:

#### <b>MO-Monday       = 0b_0000_0001</b>
#### <b>TU-Tuesday      = 0b_0000_0010</b>
#### <b>WE-Wednesday    = 0b_0000_0100</b>
#### <b>TH-Thursday     = 0b_0000_1000</b>
#### <b>FR-Friday       = 0b_0001_0000</b>
#### <b>SA-Saturday     = 0b_0010_0000</b>
#### <b>SU-Sunday       = 0b_0100_0000</b></p>
### 
### Then for example if you have someone with TU and SA as workdays their bytes would look like this  <b>0b_0010_0010</b> and to seek for matching days between employees like another employee with FR and SA and previous Employee only operating <b>employee1.Days & employee2.Days= 0b_0010_0000</b> returning only SA as Day.
### Nevertheless, even if as result we get something like <b>0b_1111_0100</b> this result will be transformed into a bit array that would be used to know wich bit is used as 1 and with that know wich day use as key on WorkingSchedule dictionary located on employee class.
### <p>[Click here for high level sequence diagram of the happy path.](//www.plantuml.com/plantuml/png/RP3TIWCn48NlynH3h-n52jw64bfaGS4VgBv0p8wxWVo4oSIoRw_RxWOLRm8vvtoPEJaKDiGrUC6EFSAzoNc2R7WKnd8Yg0L9p8VKa2aDP8Aw-ijDwZDzGqWAFfp7NnxifMmk8LUAe1vTuNqNiayJOj4jAtKJ5Toba0tXgnsnhnvl_a1RuLFAK2Cx3_QQ1Vn4cW2N49I55GtxRq9JsgXLsGgC_SycBTgwNBOgJ2uE6bvi9S9eiS2RUVTu-RMPMvzGFCjmTZmkkoQxCe2xOQTWS-gUE_bqF3qS5Tnkn05ZNuF_0W00) </p>

## <h2><u>Prerequisites</u></h2>
### - vscode
### -.Net 5.0 SDK
### - Text file with employees data (Can be found on resources folder)
# <h1><u>Instructions</u></h1>
## <h2><u>Compile instructions</u></h2>
### 1-Open powershell terminal on AcmeProject Directory
### 2-Execute the next Command on power shell 
#### COMMAND: <b>dotnet build AcmeProject.csproj</b>
## <h2><u>Run instructions</u></h2>
### 1-Create or find an employees schedule file that contains employees schedule data from employees with the next structure:
#### FORMAT: Name=Day
#### EXAMPLE:RENE=MO10:00-12:00,TU10:00-12:00,TH01:00-03:00,SA14:00-18:00,SU20:00- 21:00
### 
### 2-Open powershell terminal on AcmeProject Directory
### 3-Execute the next Command on power shell 
#### COMMAND: <b>dotnet run "C:/Path/of/File"</b>
#### <p>Note: before running this command be sure that you already built this project following <i>Compile instructions</i>.</p>
#### <p>Note 2: it is <b>not</b> mandatory to use run with arguments, but if you run it without arguments, you will need to input path manually while running this program.</p>





