---
uid: help-de-template-variables
title: Vorlagenvariablen
description: Mit Vorlagenvariablen können Sie die Eingabe von Kundendaten personalisieren und automatisieren.
keywords: Vorlagenvariablen, Dokument, Vorlage, Variable
author: Bergfrid Dias
date: 07.11.2024
version: 10.3
topic: concept
language: de
---

# Vorlagenvariablen

Mit Vorlagenvariablen können Sie Daten aus SuperOffice in E-Mails, Angebote, Besprechungsbenachrichtigungen, Dokumentvorlagen usw. einfügen. Sie können Vorlagenvariablen verwenden, um die Eingabe von Kundendaten (oder Daten von Person, Verkauf und anderen) in Ihren Inhalt zu personalisieren und zu automatisieren und komplexe Angebote einzurichten.

## Beispiel: Wie man eine E-Mail mit Vorlagenvariablen personalisiert

Anstelle des folgenden Textes:

"Sehr geehrte Kundin, sehr geehrter Kunde, möchten Sie gerne mehr darüber erfahren, wie unser Produkt Ihre Firma bei der Gewinnung von Neukunden unterstützen kann? Bitte rufen Sie uns an."

können Sie diesen abgeänderten Text senden:

"Hallo Chris, möchten Sie gerne mehr darüber erfahren, wie unser Produkt AutoPflege GmbH bei der Gewinnung von Neukunden unterstützen kann? Dann kontaktieren Sie Richard Weber bei SuperShop."

Der Text, den Sie eingeben, sieht folgendermaßen aus:

"Hallo **{atfn}**. möchten Sie gerne mehr darüber erfahren, wie unser Produkt **{name}** bei der Gewinnung von Neukunden unterstützen kann? Bitte rufen Sie **{cont}** unter **{onam}** an."

## Vorlagenvariablen verwenden

* Die gesamte Variable muss in einer Schrift und Schriftgröße formatiert werden. Es sind nur Kleinbuchstaben zulässig. Wenn allerdings die Einstellung **Vorlagenvariablen mit Unterscheidung zwischen Groß- und Kleinschreibung verwenden** aktiviert ist, kann die Vorlagenvariable formatiert werden.

* Sie können normalen Text und Variablen im Vorlagendokument kombinieren. So können Sie beispielsweise zuerst Vorlagenvariablen eingeben, die den Namen und die Adresse einer Firma abrufen, dann einen Standardtext für den Brief eingeben, und als Briefabschluss eine Variable für einen eigenen Mitarbeiter (Person) eingeben.

* Sie können auch Füllzeichen im Vorlagendokument verwenden (siehe unten).

* Das Datum und die Uhrzeit in den Vorlagenvariablen werden von der Systemuhr des PC gesteuert.

* In Dokumenten des Dateityps .doc (Office 2003 und älter) müssen Sie die Variablen anstelle von geschweiften Klammern – { } – in spitze Klammern – &lt; &gt; – setzen.

### Beispiel: Besprechungsnotizen (Kopfzeile)

Dies ist ein Beispiel für eine Kopfzeile in Besprechungsnotizen (Dokument oder E-Mail).

**Vorlage:**

```text
{head}
Datum / Ort: {sdat}, {city}
Anwesend: {attn} ({name}), {auth} ({onam})
Nicht teilgenommen:
Protokollführer: {auth} ({auem})
```

**Ergebnis:**

```text
Sommerschlussverkaufskampagne - Planung
Datum / Ort: 15.12.2019, London
Anwesend: Sara Miller (Liberty Ltd.), John Jones (SuperShop)
Nicht teilgenommen:
Besprechungsleiter: John Jones (jj@supershop.com)
```

## Füllzeichen

Es kann vorkommen, dass Sie Füllzeichen in Variablen verwenden müssen, damit der Inhalt oder die Formatierung eines Felds sich nicht verändert oder gelöscht wird, falls der Inhalt eines Felds kürzer ist als durch die Feldvariable festgelegt.

Mit der Variable padd# legen Sie das zu verwendende Füllzeichen fest. Ersetzen Sie das Nummernzeichen (#) durch den ANSI-Code des Zeichens, das Sie als Füllzeichen verwenden möchten. Eine Liste der ANSI-Codes finden Sie in der Regel im Handbuch des Programms, für das Sie Vorlagen erstellen. Microsoft Word verwendet als Füllzeichen {padd31}.

SuperOffice CRM verfügt über Füllzeichen-Standardwerte für die am häufigsten verwendeten Textverarbeitungs- und Tabellenkalkulationsanwendungen. Es wird meist ein bedingter Trennstrich verwendet, da er nicht auf dem Bildschirm oder einem Ausdruck angezeigt wird. Bei Anwendungen, deren Aufbau unbekannt ist, verwendet SuperOffice CRM {padd32}, den ANSI-Code für ein Leerzeichen.

Wenn Sie keine Füllzeichen einsetzen möchten, verwenden Sie die Vorlagenvariable {padd0}.

> [!NOTE]
> Dies gilt nur für Dokumentformate, die sequentiell sind, z. B. Notepad- und AmiPro-Vorlagen ohne Grafiken.

Wenn Sie {padd0} verwenden, können Sie alle Vorlagenvariablen ohne Leerzeichen zwischen den Namen der Vorlagenvariable und das schließende Variablenzeichen (}) schreiben.

## Intelligente Variablen auf der Firmenkarte

Adressenvariablen auf der Firmenkarte werden als "intelligente" Vorlagenvariablen bezeichnet. Das heißt, dass das System Adressdaten in einer bestimmten Reihenfolge auswählt. Die **fettgedruckten** Variablen unten (wie **addr** und **city**) sind "intelligente" Vorlagenvariablen.

Wenn Sie Adressvariablen von der Firmenkarte nutzen, wählt das System Adressdaten in folgender Reihenfolge aus:

1. Wenn die Option **Als Postadresse verwenden** für eine Person in der Firma aktiviert ist, werden die Adressdaten der Person verwendet.
2. Wenn die Option oben nicht aktiviert ist, werden die Adressdaten der Firma verwendet.
3. Wenn die Postadresse der Firma leer ist, wird die Besuchsadresse der Firma verwendet.

## Variablen für Angebotsvorlagen

Wenn Sie Angebote und Produkte in SuperOffice verwenden, müssen Sie Angebotsvorlagen einrichten. Die Variablen befinden sich in einer PDF-Datei, die auch zeigt, wie Sie mit Angebotsvorlagen arbeiten.

Die Vorlagen für Angebotsdokumente, Angebotsdetails und Auftragsbestätigungen unterscheiden sich dadurch von gewöhnlichen Dokumentvorlagen, dass sie zusätzlich zu den Standard-Vorlagenvariablen "Mergefields" verwenden.

### Beispiel: Auftragsbestätigung (Kopfzeile)

Sie können Vorlagenvariablen für Angebote und Auftragsbestätigungen im Kontext eines Angebots verwenden.

**Vorlage:**

```text
Auftragsdatum: {sdat}
Auftragsnummer: {qnum}
Lieferbedingungen: {qdev}
Zahlungsbedingungen: {qpev}
Ihre Auftragsnummer: {qpon}
Verantwortlich: {cont}
```

**Ergebnis:**

```text
Auftragsdatum: 15.12.2019
Auftragsnummer: 550012
Lieferbedingungen: Lieferung inbegriffen
Zahlungsbedingungen: 15 Tage
Ihre Auftragsnummer: 70000882
Verantwortlich: John Jones
```

## Variablen für Service und Marketingvorlagen

Beim Erstellen von E-Mail-Vorlagen für Anfragen und Kampagnen (und Nachrichtenvorlagen) im Marketing können Sie die E-Mail oder die Kampagne mit Vorlagenvariablen personalisieren. Diese Variablen unterscheiden sich geringfügig von denen, die in Dokumenten verwendet werden.

## Referenz

Die Referenz ist nach Bereich gruppiert. [Gehen Sie zu Referenz][1]

<!-- Referenced links -->
[1]: ../variables/index.md

<!-- Referenced images -->
