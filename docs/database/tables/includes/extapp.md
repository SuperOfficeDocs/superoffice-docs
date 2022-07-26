<!-- markdownlint-disable-file MD041 -->
### Value for the availableInState field in table ExtApp

The enums here may be combined.

| availableInState | ID | Comment |
|---|---|
| Always | 0 | This application is always available |
| Central db |  1 | This application is only available on the Central database |
| Satellite db | 2 | This application is only available on a Satellite database |
| Travel db | 4 | This application is only available on a Travel database |
| Sales &amp; Marketing web | 8 | This application is available on Sales &amp; Marketing Web |

### Value for the executeOnEvent field in table ExtApp

| executeOnEvent | ID | Comment |
|---|---|---|
| Never | 0 | This application is never executed automatically |
| Log on |  1 | Execute this application during logon |
| Log off | 2 | Execute this application before logoff |
| LocalUpdate | 3 | Execute this application before a local update (start travelling) |
| Wait | 16384 | When executing this application, wait for it to start |

| ShowState | ID | Comment |
|---|---|---|
| Minimized | 0 | Start application in minimized state |
| Maximized | 1 | Start application in maximized state |
| Default | 2 | Start application with default window size and position |
| Toolbar | 256 | Show the Browser toolbar |
| AddressBar | 512 | Show the Browser addressbar (where the user can type URLs) |
| StatusBar | 1024 | Show the Browser statusbar |
| MenuBar | 2048 | Show the Browser Menu bar (currently not implemeted) |

### Value for the navigation field in table ExtApp

| navigation | ID | Comment |
|---|---|---|
| Invisible | 0 | This application is always available |
| ToolboxMenu |  1 | This application is only available on the Central database |
| NavigatorButton | 2 | This application is only available on a Satellite database |
| ViewMenu | 3 | This application is only available on a Travel database |
| SelectionTaskCard | 4 | (not yet implemented) This application appears as a Task in the Selection Task |
| ContactCard | 5 | This application (type IntegratedHTML or IntegratedURL) appears as a tab on |
| ContactArchive | 6 | This application (type IntegratedHTML or IntegratedURL)  appears as a tab on |
| ProjectCard | 7 | This application (type IntegratedHTML or IntegratedURL)  appears as a tab on |
| ProjectArchive | 8 | This application (type IntegratedHTML or IntegratedURL)  appears as a tab on the Project Archive |
| SaleCard | 9 | This application (type IntegratedHTML or IntegratedURL)  appears as a tab in |
| PersonDialog | 10 | This application (type IntegratedHTML or IntegratedURL)  appears as a tab in |
| ActivityDialog | 11 | This application (type IntegratedHTML or IntegratedURL)  appears as a tab in |
| DocumentDialog | 12 | This application (type IntegratedHTML or IntegratedURL)  appears as a tab in |
| BrowserPanel | 13 | In the Browser panel |
| ContSelectionTask | 14 | Task button visible on the Contact Selection task panel |
| AppntSelectionTask | 15 | Task button visible on the Appointment Selection task panel |
| SaleSelectionTask | 16 | Task button visible on the Sale Selection task panel |
| DocSelectionTask | 17 | Task button visible on the Document Selection task panel |
| ProjSelectionTask | 18 | Task button visible on the Project Selection task panel |
| CompanyMinicard | 19 | In company minicard |
| ProjectMinicard | 20 | In project minicard |
| DiaryMinicard | 21 | In diary minicard |
| SelectionMinicard | 22 | In selection minicard |
| ButtonPanelTask | 23 | In the main ButtonBar |
| AppointmentDialogTask | 24 | In the appointment dialog |
| SaleDialogTask | 25 | In the sale dialog |
| DocumentDialogTask | 26 | In the document dialog |
| PersonDialogTask | 27 | In the person dialog |
| SaleMinicard | 28 | In the sale minicard |
| SaleArchive | 29 | In the sale archive |
| AppntSelectionShadowTask | 30 | Task tab for appointment selection, while showing shadow selection |
| SaleSelectionShadowTask | 31 | Task tab for sale selection, while showing shadow selection |
| DocSelectionShadowTask | 32 | Task tab for document selection, while showing shadow selection |
| ProjSelectionShadowTask | 33 | Task tab for project selection, while showing shadow selection |
| DiaryArchive | 34 | Context (popup) menu in Diary archive |
| SelectionContactArchive | 35 | Context (popup) menu in Contact selection |
| SelectionProjectArchive | 36 | Context (popup) menu in Project archive |
| SelectionSaleArchive | 37 | Context (popup) menu in Sale archive |
| SelectionAppointmentArchive | 38 | Context (popup) menu in Appointment archive |
| SelectionDocumentArchive | 39 | Context (popup) menu in Document archive |
| ContSelectionCustomTask | 40 | Task card in Contact selection, when a custom archive is shown |
| AppntSelectionCustomTask | 41 | Task card in Appointment selection, when a custom archive is shown |
| SaleSelectionCustomTask | 42 | Task card in Sale selection, when a custom archive is shown |
| DocSelectionCustomTask | 43 | Task card in Document selection, when a custom archive is shown |
| ProjSelectionCustomTask | 44 | Task card in Project selection, when a custom archive is shown |
| CustomArchiveMiniCard | 45 |  |
| SelectionCard | 46 |  |
| ReportMinicard | 47 | In the Reporter panel minicard, so far only in Web |
| QuoteDialog | 48 |  |
| QuoteDialogTask | 49 |  |
| QuoteDialogArchive | 50 |  |
| QuoteLineDialogTask | 51 |  |
| QuoteLineDialog | 52 |  |
| QuoteLineSelectionMainTask | 53 |  |
| QuoteLineSelectionShadowTask | 54 |  |
| SelectionQuoteLineArchive | 55 |  |
| QuoteLineSelectionCustomTask | 56 |  |
| FindSystem | 57 |  |
