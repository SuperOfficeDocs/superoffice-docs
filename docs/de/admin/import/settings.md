---
uid: help-de-import-settings
title: Importeinstellungen
description: Importeinstellungen
keywords: Importieren
author: SuperOffice Product and Engineering
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /de/admin/import/learn/configure-import-settings
language: de
---

# Importeinstellungen konfigurieren

Die Anpassung der Importeinstellungen spart Ihnen Zeit und erleichtert den korrekten Import Ihrer Daten.

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Im Dialogfenster **Importeinstellungen** können Sie den Import so anpassen, dass genau die gewünschten Produkte importiert werden. Um eine möglichst hohe Qualität der importierten Daten sicherzustellen, ist es wichtig, die richtigen Importeinstellungen anzugeben.

Dies gilt unter anderem für die folgenden Einstellungen:

* Duplikate: Legen Sie fest, wie die Information behandelt werden sollen, die sowohl in der Importdatei als auch in der Datenbank vorkommt.
* Personen, die nicht mit Firmen verknüpft sind.
* Rechtsgrundlage und Einwilligungsnachweis für Personen.
* Listen: Wählen Sie die bevorzugte Methode für die Verwaltung von Listenelementen im Import aus. Zum Beispiel neue Kategorien, Branchentypen und Telefonnummern, neue Produktkategorien, Produktfamilien und Produkttypen.

## Was Sie beachten sollten, bevor Sie Ihre Personen- oder Produktinformation importieren

* Sie können festlegen, was das System tun soll, wenn Sie Personen importieren, die bereits in SuperOffice CRM vorhanden sind. Das System kann den Abgleich überschreiben oder überspringen – das hängt von Ihrer Wahl ab.

* Sie können auswählen, ob das System automatisch neue Kategorien erstellen soll, wenn Sie eine Kategorie verwenden, die in Ihrer Importdatei in SuperOffice CRM nicht vorhanden ist.

## Typische Einsatzgebiete

* Ich will Informationen importieren, die in SuperOffice noch nicht existieren, will jedoch keine vorhandenen Informationen überschreiben.
    Wählen Sie die Option **Zusammenführen – leere Felder aktualisieren**. Wenn diese Einstellung aktiviert ist, werden nur leere Felder in SuperOffice mit importierten Informationen aktualisiert.

* Die Daten, die ich importieren möchte, sind von gesicherter Qualität, und ich möchte die Datenbank in SuperOffice aktualisieren.
    Wählen Sie die Option **Ersetzen - vorhandenes überschreiben**. Die Daten aus dem Import überschreiben vorhandene Einträge in SuperOffice-Feldern.

* Ich will nur neue Firmen und Personen in SuperOffice importieren.
    Wählen Sie die Option **Überspringen - nicht importieren**. Firmen und Personen, die bereits in SuperOffice vorhanden sind, werden nicht aktualisiert.

* Ich will nur neue Produkte in die ausgewählte Preisliste importieren.
    Wählen Sie die Option **Überspringen - nicht importieren**. Produkte, die auf der ausgewählten Preisliste bereits existieren, werden nicht aktualisiert.

* Ich will alle Firmen und Personen in SuperOffice importieren und Duplikate selbst handhaben.
    Wählen Sie die Option **Immer hinzufügen**.

* Ich will alle Produkte in die ausgewählte Preisliste importieren und Duplikate selbst handhaben.
    Wählen Sie die Option **Immer hinzufügen**.

### Beispiel

**Vorhandene Daten:**

| | Firma | Adresse | Ust-IdNr. | Code |
|---|---|---|---|---|
| **Excel/Outlook/Gmail importieren** | ACME Inc. | Broadway 123 | 11223344 | - |
| **SuperOffice** | ACME Inc. | Main street 456 | - | ACME1 |

**Aktion:**

| Aktion | Firma | Adresse | Ust-IdNr. | Code |
|---|---|---|---|---|
| **Zusammenführen** | ACME Inc. | Broadway 123 | 11223344 | ACME1 |
| **Ersetzen** | ACME Inc. | Main street 456 | 11223344 | - |
| **Datensatz überspringen** | ACME Inc. | Broadway 123 | 11223344 | ACME1 |

## Duplikate behandeln (Firma/Person)

Ein Duplikat liegt vor, wenn derselbe Datensatz sowohl in der Importdatei als auch in der Datenbank vorhanden ist. In den Importeinstellungen müssen Sie immer Regeln für die Behandlung von Duplikaten festlegen.

Unter **Firma** und **Person** und **Produkt** im Dialogfeld **Importeinstellungen** können Sie festlegen, wie Duplikate behandelt werden sollen.

1. Klicken Sie auf das Listenfeld **Treffer duplizieren** und wählen Sie die Felder aus, die zur Identifizierung von Duplikatfirmen oder -personen verwendet werden sollen.

    > [!NOTE]
    > Um zu verhindern, dass ungewollt Daten überschrieben werden, sollten Sie die Option wählen, die für jede Firma, jede Person und jedes Produkt eindeutig ist.
    >
    > Die ausgewählten Daten für die Duplikatkontrolle MUSS in der Importdatei existieren. Wenn Sie Name+Produktnummer wählen, muss Ihre Importdatei mindestens diese Spalten enthalten.

1. Klicken Sie auf das Listenfeld **Aktion** und geben Sie an, wie doppelte Treffer behandelt werden sollen:

    * **Immer hinzufügen**:
      * Neue Firmen, Personen und Produkte werden immer hinzugefügt, auch wenn Duplikate vorhanden sind.
      * Neue Produkte werden auch dann hinzugefügt, wenn es Duplikate gibt.

    * **Zusammenführen – Leere Felder aktualisieren**:
      * Wenn SuperOffice für vorhandene Firmen und Personen leere Felder enthält, werden in diese Felder mit Daten aus der Importquelle ausgefüllt. Bereits vorhandene Daten in SuperOffice-Feldern werden nicht überschrieben.

      * Wenn vorhandene Produkte in der ausgewählten Preisliste leere Felder aufweisen, werden diese leeren Felder mit Daten aus der Importquelle ausgefüllt. Vorhandene Daten in der ausgewählten Preisliste werden nicht überschrieben.

    * **Ersetzen - vorhandenes überschreiben**:
      * Importdaten überschreiben vorhandene Daten in SuperOffice-Feldern.
      * Die Importdaten werden in der ausgewählten Preisliste vorhandene Daten überschreiben.

    * **Überspringen – Nicht importieren**:
      * Firmen und Personen, die bereits in SuperOffice vorhanden sind, werden nicht importiert.
      * Produkte, die auf der ausgewählten Preisliste bereits existieren, werden nicht importiert.

### Optionen für Treffer duplizieren

**Firma:**

* **Name**: Der Firmenname muss identisch sein.
* **Name + Abteilung**: Firmenname und Abteilung müssen identisch sein.
* **Nummer**: Die Firmennummer muss identisch sein.
* **Produktnummer**: Der Firmencode muss identisch sein.
* **USt.-ID-Nr.**: Die Umsatzsteuernummer der Firma muss identisch sein.
* **ID**: Die ID der Firma muss identisch sein.

**Person:**

* **Name**: Der vollständige Name (Vorname + Nachname) der Person muss identisch sein.
* **E-Mail-Adresse**: Die E-Mail-Adresse der Person muss identisch sein.
* **Mobiltelefon**: Die Mobiltelefonnummer der Person muss identisch sein.
* **Nummer**: Die Personennummer muss identisch sein.
* **Keine – Person nicht importieren**: Wählen Sie diese Option, wenn Sie keine Personen importieren wollen.
* **ID**: Die Personen-ID muss identisch sein.

**Produkt:**

* **Name**: Der Produktname muss identisch sein.
* **Produktnummer**: Die Produktnummer muss identisch sein.
* **Name + Code**: Sowohl Produktname als auch Produktnummer müssen identisch sein.

## Personen behandeln, die nicht zu einer Firma gehören

Wenn Personen in der Importquelle nicht zusammen mit einer Firma aufgeführt werden, stehen im Listenfeld **Wenn kein Firmenname** drei Optionen zur Verfügung:

* **Firma aus Kontaktnamen erstellen**: Eine Firma mit dem Namen der Person wird erstellt, wobei sie die einzige Person ist.

* **Überspringen – Firma oder Person nicht erstellen**: Die Person wird nicht importiert.

* **Personen ohne Firma importieren**: Die Person wird ohne Link zu einer Firma importiert. Diese Option ist nur verfügbar, wenn die globale Einstellung **Firma für Person obligatorisch** auf **Nein** gesetzt ist.

## Datenschutzoptionen für importierte Personen

Beim Import von Personen müssen Sie zudem die Rechtsgrundlage und den Einwilligungsnachweis für den Zweck **Verkauf und Service** einstellen:

* **Rechtsgrundlage**: Wählen Sie eine [Rechtsgrundlage][1] aus der Liste aus oder wählen Sie **Standard verwenden**, wenn Sie die in der Ansicht Datenschutz (siehe Datenschutz) definierte Standardrechtsgrundlage verwenden möchten.

* **Einwilligungsnachweis**: Dieser Wert ist standardmäßig auf **Import** gesetzt, Sie können in der Liste aber einen anderen Wert auswählen.

## Listenwerte behandeln, die in SuperOffice nicht existieren

Die Importquelle kann unter Umständen beispielsweise Branchen enthalten, die in SuperOffice nicht registriert sind. In diesem Fall müssen Sie auswählen, wie neue Kategorien, Geschäfte, benutzerdefinierte Listenwerte und Interessen gehandhabt werden sollen. In den Listenfeldern unter **Listen** stehen folgende Optionen zur Verfügung:

* **Neues Objekte zu Liste hinzufügen**: In SuperOffice werden neue Werte hinzugefügt.
* **Ignorieren – Standard verwenden**: Es werden keine neuen Werte importiert, sondern der Standardwert für Kategorie oder Geschäft verwendet. Sie legen den Standardwert unter **Einstellungen** > **Standardwerte** fest.

    > [!NOTE]
    > **Position** hat keinen Standardwert.

* **Ignorieren – auf leeres Feld zurücksetzen**: Es werden keine neuen Werte in SuperOffice importiert.

## Neue Telefonnummern, Links und E-Mail-Adressen behandeln

Die Importquelle kann beispielsweise Telefonnummern, Links und E-Mail-Adressen enthalten, die nicht in SuperOffice registriert sind. Da es möglich ist, mehrere Telefonnummern, Links und E-Mail-Adressen für eine einzelne Firma/Person zu registrieren, müssen Sie angeben, wie neue Werte behandelt werden sollen. In den Listenfeldern **Telefonnummer** und **URLs + E-Mail** unter **Listen** stehen folgende Optionen zur Verfügung:

* **Neues hinzufügen - vorhandenes beibehalten**: Neue Werte werden zu SuperOffice hinzugefügt, und vorhandene Werte werden behalten.
* **Ersetzen - vorhandenes überschreiben**: Vorhandene Werte in SuperOffice werden mit importierten Werten überschrieben.
    Zum Beispiel: Diese Option kann infrage kommen, wenn Sie sicher sind, dass die Importdaten die richtigen E-Mail-Adressen für Ihre Personen enthalten. Wenn die in SuperOffice registrierten E-Mail-Adressen veraltet sind, können Sie sie überschreiben, um das System zu aktualisieren.
* **Ignorieren - vorhandenes beibehalten**: Es werden keine neuen Werte in SuperOffice importiert.

## Produktkategorien, Produktfamilien und Produkttypen nicht in SuperOffice verwalten

Die Importquelle kann unter Umständen beispielsweise Produktkategorien enthalten, die in SuperOffice nicht registriert sind. In diesem Falle müssen Sie auswählen, wie neue Produktkategorien, Produktfamilien und Produkttypen verwaltet werden sollen. Im Listenfeld **Neue Werte für...** stehen folgende Optionen zur Verfügung:

* **Neues Objekte zu Liste hinzufügen**: In SuperOffice werden neue Werte hinzugefügt.
* **Ignorieren – auf leeres Feld zurücksetzen**: Es werden keine neuen Werte in SuperOffice hinzugefügt.

<!-- Referenced links -->
[1]: ../../security/privacy/learn/index.md

<!-- Referenced images -->
