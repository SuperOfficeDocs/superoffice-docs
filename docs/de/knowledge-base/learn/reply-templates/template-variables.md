---
uid: help-de-template-variables-service
title: Vorlagenvariablen
description: Vorlagenvariablen
keywords: Vorlagenvariable
author: SuperOffice Product and Engineering
date: 06.29.2022
version: 10.5
content_type: reference
category: service
topic: knowledge base
audience: person
audience_tooltip: SuperOffice Service
language: de
redirect_from: /de/request/reply-templates/learn/template-variables
---

# Vorlagenvariablen (Service)

Sie können in der E-Mail-Nachricht Vorlagenvariablen verwenden, um kundenspezifische Informationen einzufügen, die der Mitteilung eine persönlichere Note verleihen. Dadurch können Sie den Inhalt an jeden Kunden individuell anpassen.

In den folgenden Tabellen sind alle Vorlagenvariablen für SuperOffice Service und SuperOffice Marketing aufgeführt.

Bei der Bearbeitung von Vorlagen und Kampagnen können Sie Vorlagenvariablen einfügen, indem Sie die Variable zwischen zwei eckigen Klammern (\[\[ \]\]) eingeben. Beispiel: **\[\[customer.name\]\]**. Im HTML-Editor können Sie ebenfalls die häufigsten Variablen aus dem Menü **Vorlagenvariable** auswählen.

## Anlagen (nur SuperOffice Marketing)

| Variable | Beschreibung|
|---|---|
| attachment.downloadUrl | Link zum Herunterladen des Anhangs |
| attachment.name | Dateiname des Anhangs |
| attachment.openUrl | Link zum Öffnen des Anhangs |
| InEmailClient | 1: wenn die E-Mail-Nachricht im E-Mail-Client gezeigt wird, nicht vorhanden: wenn die E-Mail-Nachricht online in einem Browser gezeigt wird |
| isWebPage | 1: wenn die E-Mail-Nachricht online in einem Browser gezeigt wird |

## Lizenz-Info

| Variable | Beschreibung|
|---|---|
| licence.admin | 1: wenn der Kunde eine Lizenz für Admin hat, ansonsten: 0 |
| licence.advancedfaq | 1: wenn der Kunde eine Lizenz für Erweiterte FAQ hat, ansonsten: 0 |
| licence.ajax | 1: wenn der Kunde eine Lizenz für Ajax hat, ansonsten: 0 |
| licence.blogic | 1: wenn der Kunde eine Lizenz für bLogic hat, ansonsten: 0 |
| licence.chat | 1: wenn der Kunde eine Lizenz für Chat hat, ansonsten: 0 |
| licence.custlang | 1: wenn der Kunde eine Lizenz für CustLang hat, ansonsten: 0 |
| licence.customer | 1: wenn der Kunde eine Lizenz für Customer hat, ansonsten: 0 |
| licence.document | 1: wenn der Kunde eine Lizenz für Document hat, ansonsten: 0 |
| licence.extdb | 1: wenn der Kunde eine Lizenz für Extdb hat, ansonsten: 0 |
| licence.help | 1: wenn der Kunde eine Lizenz für Help hat, ansonsten: 0 |
| licence.knowledge | 1: wenn der Kunde eine Lizenz für Knowledge hat, ansonsten: 0 |
| licence.logout | 1: wenn der Kunde eine Lizenz für Logout hat, ansonsten: 0 |
| licence.macro | 1: wenn der Kunde eine Lizenz für Macro hat, ansonsten: 0 |
| licence.retail | 1: wenn der Kunde eine Lizenz für Retail hat, ansonsten: 0 |
| licence.rms | 1: wenn der Kunde eine Lizenz für RMS hat, ansonsten: 0 |
| licence.sms | 1: wenn der Kunde eine Lizenz für SMS hat, ansonsten: 0 |
| licence.soap | 1: wenn der Kunde eine Lizenz für Soap hat, ansonsten: 0 |
| licence.soapPublic | 1: wenn der Kunde eine Lizenz für Soap Public hat, ansonsten: 0 |
| licence.spm | 1: wenn der Kunde eine Lizenz für SPM hat, ansonsten: 0 |
| licence.standardEdition | 1: wenn der Kunde eine Lizenz für Standard Edition hat, ansonsten: 0 |
| licence.stat | 1: wenn der Kunde eine Lizenz für Stat hat, ansonsten: 0 |
| licence.ticket | 1: wenn der Kunde eine Lizenz für Ticket hat, ansonsten: 0 |

## Links (nur SuperOffice Marketing)

| Variable | Beschreibung|
|---|---|
| Link für die Anzeige der Nachricht im Internet | URL, um die E-Mail-Nachricht online in einem Browser anzuzeigen, z. B. "Klicken Sie hier, wenn diese Nachricht verdächtig aussieht." |
| link.subscription | Der Link zum Beenden Ihres Abonnements |
| link.viewShipmentMessage | Der Link, um die E-Mail-Nachricht online zu sehen |

## <a id="config"></a>Verwaltung

| Variable | Beschreibung|
|---|---|
| config.adminMail | Die E-Mail-Adresse für den Systemadministrator für diese Installation |
| config.cgiBin | Das URL-Suffix für die ausführbaren Programmdateien |
| config.cgiUrl | Die externe Basis-URL für die Installation |
| config.cgiUrlInternal | Die interne Basis-URL für die Installation |
| config.companyAddress | Die Adresse der eigenen Firma. |
| config.companyName | Der Name der eigenen Firma. |
| config.defaultMail | Die Standard-E-Mail-von-Adresse für diese Installation |
| config.gfxUrl | Das URL-Suffix für die GFX-Dateien |
| config.mailTag | Der Satz "Bitte Ticket-ID einbeziehen...", der als erste Zeile in ausgehenden E-Mails verwendet wird |
| config.panicMail | Die E-Mail-Adresse, an die Fehlermeldungen gesendet werden sollen |
| config.smtpHost | Der Hostname für das abgehende SMTP |
| config.smtpPort | Der Port für das abgehende SMTP |
| config.tag | Das Präfix vor der Anfragenummer in der Betreffzeile für E-Mails. Zum Beispiel, "ejTag:" |
| config.uniqueId | Die eindeutige ID für diese Installation |
| config.warning | Der Pfad für die Warnungs-Logdateien |
| config.wwwPath | Der Systempfad für WWW-Dateien |

## <a id="customer"></a>Variablen für eine ausgewählte Person

| Variable | Beschreibung|
|---|---|
| customer.bestName | Der beste verfügbare Name für diesen Kunden |
| customer.cellphone | Mobilfunknummer |
| customer.deleted | 1: wenn dieser Kunde gelöscht wird |
| customer.email | E-Mail-Adresse |
| customer.firstname | Vorname |
| customer.id | Personen-ID (ausgeblendet, eindeutige ID) |
| customer.language | Für Kontakt ausgewählte Sprache |
| customer.lastname | Nachname |
| customer.middlename | Zweiter Vorname |
| customer.mrmrs | Feld Herr/Frau |
| customer.name | Vollständiger Name |
| customer.note | Notiz |
| customer.ourContact | Die ID (ejuser) des Agenten, der als der primäre Support-Ansprechpartner für diesen Kunden markiert ist |
| customer.password | Passwort in SuperOffice Kundenzentrum |
| customer.phone | Telefonnummer |
| customer.salutation | Anrede: der vollständige Name, falls vorhanden, oder die E-Mail-Adresse, wenn kein Name bekannt ist |
| customer.title | Titel |
| customer.username | Benutzername in SuperOffice Kundenzentrum |
| makeSalutation(customer.id) | Anrede |

## <a id="ticket"></a>Variablen für Anfragen (nur SuperOffice Service)

| Variable | Beschreibung|
|---|---|
| ticket.activate | Wenn die Anfrage aktiviert wird, wenn sie sich im auf Termin gelegten Status befindet |
| ticket.alertLevel | Warnstufe |
| ticket.author | Der Name der Person, die die Anfrage erstellt |
| ticket.category | Wie ticket.category.id |
| ticket.category.externalName | Kategorie, externer Name |
| ticket.category.fullname | Kategorie |
| ticket.category.id | Kategorie-ID (ausgeblendet, eindeutige ID) |
| ticket.category.name | Der Name der Kategorie für das Ticket |
| ticket.closedAt | Wenn die Anfrage geschlossen wurde |
| ticket.closedAtRaw | Der Zeitpunkt, zu dem die Anfrage geschlossen wurde in JJJJ-MM-TT SS |
| ticket.createdAt | Der Zeitpunkt, zu dem die Anfrage im Standardformat des Benutzer erstellt wurde |
| ticket.createdAtRaw | Der Zeitpunkt, zu dem die Anfrage erstellt wurde in JJJJ-MM-TT SS |
| ticket.customer | Die ID des Kunden für die Anfrage |
| ticket.customerName | Der Ansprechpartner, Name für die Anfrage |
| ticket.customerUrl | Die URL für den Zugriff auf die Anfrage des Kunden |
| ticket.customerUrlEnc | Die URL für den Zugriff auf die Anfrage des Kunden, URL-kodiert |
| ticket.customerUrlOld | Die URL für den Zugriff auf die Anfrage des Kunden, nicht kodiert Wird zur Rückwärtskompatibilität beibehalten. |
| ticket.dbiAgentId | Die ID des DBI-Mitarbeiters, wenn diese Anfrage mittels DBI synchronisiert wurde |
| ticket.dbiKey | Der externe Primärschlüssel, wenn diese Anfrage mittels DBI synchronisiert wurde |
| ticket.deadline | Die Bearbeitungsfrist der Anfrage |
| ticket.id | Anfrage-ID (ausgeblendet, eindeutige ID) |
| ticket.lastChanged | Der Zeitpunkt, zu dem die Anfrage im Standardformat des Benutzer zuletzt geändert wurde |
| ticket.lastChangedRaw | Der Zeitpunkt, zu dem die Anfrage zuletzt geändert wurde in JJJJ-MM-TT SS |
| ticket.ownerCellphone | Der Eigentümer der Anfrage, Mobilfunknummer |
| ticket.ownerFullName | Der Eigentümer der Anfrage, vollständiger Name |
| ticket.ownerUsername | Der Eigentümer der Anfrage, Benutzername |
| ticket.priority | Priorität |
| ticket.readByCustomer | Datum/Uhrzeit, zu dem die Anfrage vom Kunden im Standardformat des Benutzers gelesen wurde |
| ticket.readByCustomerRaw | Datum/Uhrzeit, zu dem die Anfrage vom Kunden gelesen wurde in JJJJ-MM-TT SS |
| ticket.readByOwner | Datum/Uhrzeit, zu dem die Anfrage vom Eigentümer im Standardformat des Benutzers gelesen wurde |
| ticket.readByOwnerRaw | Datum/Uhrzeit, zu dem die Anfrage vom Eigentümer gelesen wurde in JJJJ-MM-TT SS |
| ticket.slevel | Die Zugriffsebene des Tickets (1 = intern, 2 = extern) |
| ticket.status | Der Name des Status (offen, geschlossen, aufgeschoben) |
| ticket.ticketStatus | Der Name des benutzerdefinierten Status |
| ticket.title | Titel der Anfrage |
| ticket.url | Die URL für den Zugriff auf die Anfrage durch Benutzeragenten |
| ticket.urlWithSession | Die URL für den Zugriff auf die Anfrage durch Benutzeragenten in der aktuellen Benutzersitzung |
| ticket.userUrl | Die URL für den Zugriff auf die Anfrage durch Benutzeragenten |

## <a id="company"></a>Variablen für ausgewählte Firma

| Variable | Beschreibung|
|---|---|
| company.adr | Adresse |
| company.department | Abteilung |
| company.domain | Domain |
| company.fax | Faxnummer |
| company.id | Firmen-ID (ausgeblendet, eindeutige ID) |
| company.name | Firmenname |
| company.note | Notiz |
| company.ourContact | Wie company.primaryContact.id |
| company.ourContact.cellphone | Verantwortlich, Mobilfunknummer |
| company.ourContact.email | Verantwortlich, E-Mail-Adresse |
| company.ourContact.name | Verantwortlich, Name |
| company.ourContact.phone | Verantwortlich, Telefonnummer |
| company.ourSalesContact | Die ID (Partner) des KAM der Firma |
| company.ourSalesContact.cellphone | Unser Vertriebsverantwortlicher, Mobilfunknummer |
| company.ourSalesContact.email | Vertriebs-Ansprechpartner, E-Mail-Adresse |
| company.ourSalesContact.name | Unser Vertriebsverantwortlicher, Name |
| company.ourSalesContact.phone | Unser Vertriebsverantwortlicher, Telefonnummer |
| company.phone | Telefonnummer |
| company.primaryContact.email | Hauptperson, E-Mail-Adresse |
| company.primaryContact.id | Die ID (ejuser) des Agenten, der als der primäre Support-Ansprechpartner für diese Firma markiert ist |
| ourContact.email | Verantwortliche, E-Mail-Adresse |
| ourContact.name | Verantwortlich |

## <a id="user"></a>Variablen für Antwortvorlagen (Benutzer) (nur SuperOffice Service)

Bitte beachten Sie, dass diese Variablen nicht für vom System gesendete automatisierte Antworten funktionieren werden, weil solche Antworten nicht mit einem Benutzer verknüpft sind.

| Variable | Beschreibung|
|---|---|
| user.access | Der funktionelle Zugriff des Senders als eine Bitmask |
| user.dictionary | Die Standard-Wörterbuchsprache des Benutzers |
| user.email | E-Mail-Adresse |
| user.firstname | Vorname |
| user.id | Der Primärschlüssel des Senders in der ejuser-Tabelle |
| user.language | Ausgewählte Sprache des Senders |
| user.lastname | Nachname |
| user.loginname | Anmeldename |
| user.middlename | Zweiter Vorname |
| user.name | Der vollständige Name des Benutzeragenten |
| user.signature | Die Signatur des Senders aus den Einstellungen |
| user.status | Der Status des Senders (1 = normal, 2 = nicht verfügbar, 3 = gelöscht) |
| user.username | Der Benutzername des Senders, entspricht nicht unbedingt dem Anmeldenamen |

## Bedingte Werte

\[\[IF:condition="1"\]\]

Bedingung ist eins

\[\[ELSEIF:condition="2"\]\]

Bedingung ist zwei

\[\[ELSE\]\]

Bedingung ist etwas anderes

\[\[ENDIF\]\]

Aus Werten auswählen:

\[\[DECODE:expr,"value1","return1","value2","return2","default"\]\]

Variable festlegen:

\[\[SET:name="value"\]\]

Variable erhöhen:

\[\[INC:variable\]\]

Variable erniedrigen:

\[\[DEC:variable\]\]

Datum formatieren:

\[\[FORMAT-DATE:"date","YY4 MM2 DD2 HH24:MI2:SS2"\]\]

Uhrzeit formatieren:

\[\[SEC-TO-TIME:"seconds","h:m:s"\]\]
