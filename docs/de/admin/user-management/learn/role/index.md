---
uid: help-de-role
title: Rolle
description: Rolle
author: Kirsti Aakerholt
date: 04.19.2023
keywords: Rolle, Datenobjekt, Benutzerebene
content_type: concept
audience: admin
audience_tooltip: Settings and maintenance
language: de
---

# Rollen

[!include[Requirement](../includes/note-anon-req.md)]

Über die rollenbasierte Sicherheit in SuperOffice CRM können Sie für die verschiedenen Zugriffsebenen in der Firma Rollen festlegen. Die Rollen steuern die Zugriffsrechte der verschiedenen Benutzer in den SuperOffice CRM-Modulen.

Eine Rolle legt Folgendes fest:

* Welche **Datenobjekte** (Firma, Person, Projekt, Projektmitglieder, Selektion, Verkauf, Beteiligter, Folgeaufgabe, Dokument, Beziehung, Dashboards und Ziel) für die Benutzer zugänglich gemacht werden sollen, die diese Rolle haben.

    Der Zugriff wird anhand von Rechten festgelegt: keine, Lesen, Erstellen, Abgleichen und Löschen.

* Welche **Funktionen** (zum Beispiel Administratorzugriff in Einstellungen und Verwaltung, Massenabgleich zulassen, Angebotsgenehmigung, Serienbriefe, Exportieren von Selektionen und Veröffentlichen) sollen Benutzern mit dieser Rolle zugänglich gemacht werden.

## Vordefiniert Rollen

Vordefinierte Rollen sind in SuperOffice CRM inbegriffen. Die Rollen der **Benutzerebenen 0–5** entsprechen den Benutzerebenen älterer Versionen von SuperOffice, wobei die Benutzerebene 0 einem Administrator entspricht. Die vorgegebenen Rollen können nach Bedarf bearbeitet werden.

| Rolle | Erläuterung |
|---|---|
| Benutzerebene 0 | Administrator: Hat uneingeschränkten Zugriff auf alle Daten. Kann alle Systembereiche verwalten. |
| Benutzerebene 1 | Superuser: Hat uneingeschränkten Zugriff auf Daten, kann jedoch das System nicht verwalten. |
| Benutzerebene 2 | Hat uneingeschränkten Zugriff innerhalb der eigenen Benutzergruppe, aber eingeschränkten Zugriff darüber hinaus. |
| Benutzerebene 3 | Hat uneingeschränkten Zugriff auf eigene Daten und kann Daten innerhalb der eigenen Benutzergruppe lesen. Darüber hinaus ist der Zugriff eingeschränkt. |
| Benutzerebene 4 | Hat uneingeschränkten Zugriff auf eigene Daten, jedoch eingeschränkten Zugriff auf Daten innerhalb der eigenen Benutzergruppe und darüber hinaus. |
| Benutzerebene 5 | Hat Lesezugriff auf die meisten Daten, jedoch eingeschränkten Zugriff auf die Daten anderer Benutzer. Kann Aktivitäten erstellen. |
| Listenadministrator | Hat uneingeschränkten Zugriff auf Daten im SuperOffice CRM-Client. Kann mithilfe von Einstellungen und Verwaltung Listen im System bearbeiten (zum Beispiel Dokumentvorlagen und Kategorien). |
| Benutzeradministrator | Hat uneingeschränkten Zugriff auf Daten. Kann mithilfe von Einstellungen und Verwaltung Benutzer im System erstellen und bearbeiten. |
| Lokaler Benutzer | Hat uneingeschränkten Zugriff auf eigene Daten, aber keinen Zugriff auf Daten von Benutzern in anderen Firmen. |
| Externer Benutzer | Berater oder Partner mit begrenztem Zugriff auf Firmen- und Projektdaten. Hat nur Zugriff auf veröffentlichte Daten. |
| Anonymer Benutzer | Anonymer Benutzer |
| Systembenutzer | Systemintegrationsbenutzer. Umgeht alle Sicherheitsprüfungen. Diese Rolle ist nicht sichtbar und kann nicht bearbeitet werden. |

### Benutzer- oder Administratorrolle

Wenn Sie einer neuen Person Zugriff gewähren, müssen Sie deren Rolle angeben – entweder Benutzer oder Administrator.

Administratoren haben Zugriff auf den Abschnitt Einstellungen und Verwaltung. Hier können Sie Benutzer erstellen, Zugriffsrechte anpassen und die CRM-Lösung nach Ihren Bedürfnisse personalisieren. Wenn Sie einem Benutzer diesen Zugriff erteilen möchten, geben Sie ihm die Benutzerebene 0.

Wenn Sie nicht möchten, dass Benutzer Zugriff auf Einstellungen und Verwaltung haben, weisen Sie ihnen je nach dem benötigten Zugriff die Benutzerebene 1 oder höher zu.

## Ihre Rollen verwalten

Im Bereich Rollen können Sie den [Zugriffstyp festlegen][3], die Ihre Benutzer auf die verschiedenen Teile von SuperOffice CRM haben. Sie können auch jede Benutzerebene anpassen, indem Sie die Datenrechte und/oder die verschiedenen [Funktionsrechte][6] ändern.

![Im Abschnitt Rollen können Sie festlegen, welchen Zugriffstyp Ihre Benutzer auf die verschiedenen Teile von SuperOffice CRM haben -screenshot][img1]

Sie können zum Beispiel auf der Registerkarte Datenrechte entscheiden, ob eine Person Informationen löschen, aktualisieren, erstellen oder lesen kann. Auf der Registerkarte Funktionelle Rechte können Sie unterschiedliche funktionelle Rechte für die verschiedenen Rollen zulassen, wie zum Beispiel Massenabgleich zulassen oder Listenadministrator, indem Sie sie in die rechte Spalte für "Diese Rolle kann" verschieben.

| Rolle | Erläuterung | Keine | Lesen | Erstellen | Abgleichen | Löschen |
|---|---|:-:|:-:|:-:|:-:|:-:|
| Keine | Keine Rechte und kann nicht sehen | X |  |  |  |  |
| Lesen | Kann lesen |  | X |  |  |  |
| Erstellen | Kann erstellen |  | X | X |  |  |
| Abgleichen | Kann aktualisieren |  | X | X | X |  |
| Löschen | Kann löschen |  | X | X | X | X |

## Was möchten Sie jetzt tun?

* [Rolle erstellen][1]
* [Rolle bearbeiten][2]
* [Datenrechte für eine Rolle festlegen][3]
* [Rechte für anonyme Benutzer bearbeiten][4]
* [Rolle löschen][5]
* [Funktionsrechte][6]

<!-- Referenced links -->
[1]: create-role.md
[2]: editing-role.md
[3]: set-data-rights-for-role.md
[4]: edit-rights-for-anonymous-users.md
[5]: deleting-role.md
[6]: functional-rights.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/manage-user-levels.png
