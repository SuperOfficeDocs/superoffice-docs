---
uid: so-protocol-nav
title: Navigation points (where)
description: SoProtocol navigation targets, dialog targets, query parameters, and admin screens reference
keywords: soprotocol, deeplinking, navigation, targets
author: Michel Krohn-Dale, digitaldiina, MargretheR
date: 29.05.2026
version: 11
content_type: reference
category: customization
topic: soprotocol
platform: web
redirect_from: /en/ui/soprotocol/navigation-points
language: en
---

# SoProtocol targets reference

SoProtocol targets define the `{{WHERE}}` part of an SoProtocol URL — which screen to open and which tabs to activate. The `{{WHAT}}` query parameters are covered in the [Query parameters](#query-parameters) section below.

## Main screen targets

| Entity | Target | Upper tab views | Lower tab views | Notes |
|--------|--------|-----------------|-----------------|-------|
| Chat | chat | main | - | |
| Company | contact | main, udef, interest, info | personarchive, relationarchive, projectarchive, activityarchive, salearchive, ticketarchive | |
| Custom object (pilot) | customobject?customobject_name= | - | - | |
| Custom objects overview | customobjectoverview | main | - | |
| Dashboards | dashboard2 | main | - | <i class="ph ph-warning" aria-hidden="true"></i> Not `dashboard` or `dashboards` |
| Diary | diary | day, week, month, view | activityarchive, diarysalearchive | |
| Email flows | flows | main | - | |
| Free-text search results | freetextresult | main | - | |
| Inbox | newinbox | main | - | <i class="ph ph-warning" aria-hidden="true"></i> Not `mailbox` |
| Marketing | emarketing | mailings, mmlisttemplates, mmlistlinks, mmlistimages, mmlistbounces, mmlistforms, mmlistformtemplates, mmlistformsubmissions | - | |
| Person | person | main, details, udef, interest, info | projectarchive, relationarchive, activityarchive, salearchive, ticketarchive | |
| Project | project | main, udef, info, image, links | guide, projectmembersarchive, activityarchive, salearchive, ticketarchive | |
| Requests | ticket | main, findticket | - | Requires NewServiceRequest feature toggle |
| Sale | sale | main, details, udef, links, info | guide, quote, saleactivityarchive, stakeholderarchive, ticketarchive | |
| Selection | selection | - | - | Auto-rewrites — [see below](#selection-auto-rewriting) |
| Selection — board/kanban | selectionboard | main | - | Requires BoardView feature toggle |
| Selection — browse view | selectionbrowse | main | - | |
| Selection — find view | selectionfind | main | - | For new selections (`selection_id=0`) |
| Selection — search view | selectionsearch | main, findpane, detailspane, newchartspane, selmailingspane, webpanelpane | - | For existing selections |
| Simple iframe | simpleiframe | main | - | |
| Web panel browser | browser | main | - | |

## Selection auto-rewriting

When you use `selection` as the target, the protocol parser automatically rewrites the URL based on the value of `selection_id`:

| Condition | Rewrites to | Purpose |
|-----------|-------------|---------|
| `selection_id=0` | `selectionfind` | Open the create-new-selection view |
| `selection_id=` existing ID | `selectionsearch` | Open an existing selection |

You can also navigate directly to `selectionbrowse` or `selectionboard` for alternative views.

## Dialog targets

The following targets open dialogs rather than navigating to a full screen. In SCIL pages, navigation uses `SCIL.Router.navigateTo()`.

| Target | Dialog | Notes |
|--------|--------|-------|
| appsettings | Application settings | |
| appointment | Follow-up/appointment | Tabs: main, details, status, links, udef |
| consentperson | Consent for person | |
| document | Document | Tabs: main, links, more |
| find | Find dialog | |
| groupview | Group view (diary) | |
| invitations | Invitations | Tabs: archive, main |
| maildialog | Email compose | |
| preferences | User preferences | |
| recyclebin | Recycle bin | |
| relation | Relation | |
| statusmonitor | Saint status monitor | |

## Query parameters

The `?what` portion of an SoProtocol URL specifies which record to display. The following entity ID parameters are supported:

| Parameter | Entity |
|-----------|--------|
| appointment_id | Follow-up/appointment |
| associate_id | Associate/user |
| contact_id | Company/contact |
| dashboard_id | Dashboard |
| day_id / week_id / month_id | Calendar date navigation |
| diaryowner_id | Diary owner |
| document_id | Document |
| email_flow_id | Email flow |
| person_id | Person |
| project_id | Project |
| sale_id | Sale |
| selection_id | Selection |
| ticket_id | Request/ticket |

**Example:** `superoffice:contact.main.personarchive?contact_id=5&person_id=10`

## Admin targets

The following targets navigate to administrator screens. The signed-in user must have administrator rights.

| Target | Admin area |
|--------|-----------|
| adminlicense | Licenses |
| adminusers | Users |
| adminroles | Roles |
| adminprivacy | Privacy |
| adminsaint | SAINT |
| adminhugoai | AI services |
| adminlists | Lists |
| adminquote | Quote/Sync |
| adminworkflow | Workflow |
| adminconfigscreens | Screen designer |
| adminpreferences | Preferences |
| adminchat | Chat |
| adminmarketing | Marketing |
| adminsystem | Options |
| adminimportwizard | Import |
| adminfields | Fields |
| crmscript | CRMScript |
| adminrequests | Requests |
| admincustcenter | Customer center |
| adminsystemdesign | System design |

## Minicard addresses

The following minicard addresses are available:

* minicontact
* miniperson
* miniday
* minimonth
* minifavourites
* mininextday
* mininotepad
* minipreview
* miniproject
* miniprojectmembers
* minisale
* miniselection
* miniselectionmembers
* miniweek

## Examples

* To go to the contact screen, select the main details and select the person grid
  * `contact.main.personarchive`

* To go to the contact screen, select the interests tab, and select the project grid in the lower tab view, and view the company information in the minicard view.
  * `contact.interest.projectarchive.minicontact`

* To go to the diary and view the *day* tab: `diary.day`
