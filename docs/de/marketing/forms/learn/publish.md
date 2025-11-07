---
uid: help-de-form-publish
title: Formulare veröffentlichen
description: Formulare veröffentlichen
keywords: Formular, Formulare veröffentlichen, Felder vorausfüllen, vorausgefüllt, vorausgefüllts Feld, Feldidentifikator, Feldbezeichnung, Formular einbetten, Skript-Tag, veröffentlichen, UTM-Builder, UTM-Tracking hinzufügen
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: de
redirect_from: /de/marketing/forms/learn/form-prefilled
---

# Formulare veröffentlichen

Nachdem Sie ein Formular und (falls relevant) das Antwortformular erstellt haben, können Sie das Formular veröffentlichen.

> [!NOTE]
> Die Registerkarte **Veröffentlichen** ist ein Arbeitsbereich für den aktuellen Moment. Alle Werte, die Sie auf dieser Seite eingeben – zum Beispiel vorausgefüllte Felder oder UTM-Parameter – werden nur verwendet, um den Link oder das Skript zu erzeugen, das Sie jetzt kopieren.
> SuperOffice speichert diese Werte **nicht** dauerhaft. Wenn ein anderer Benutzer die Seite später bearbeitet, werden Ihre vorherigen Werte überschrieben.

## Schritte

1. Gehen Sie zur Registerkarte **Formulare**.

1. Klicken Sie auf das Formular, um es im Ansichtsmodus zu öffnen.

1. Setzen Sie das Formular in der Kopfzeile auf **Aktiv** <i class="ph ph-toggle-right" aria-label="Toggle on"></i>.

1. Gehen Sie zur Registerkarte **Veröffentlichen**.

1. Wählen Sie auf der linken Seite der Ansicht eine Veröffentlichungsoption für das Formular aus:

    * **Direkter Link**: Direkter Link zum Formular.
    * **Inline einbetten**: Skript-Tag zum Hinzufügen des Formulars auf einer Webseite.
    * **Als Popup einbetten**: Option zum Öffnen des Formulars in einem Popup-Fenster auf der Webseite.
    * **Als seitliche Registerkarte einbetten**: Eine seitliche Registerkarte mit einer Schaltfläche zum Aus-/Einblenden des Formulars.

1. (optional) Wählen Sie im Abschnitt **Mit Kontaktdaten vorausfüllen** ein oder mehrere Felder aus, die automatisch mit vorhandenen Kundendaten von SuperOffice ausgefüllt werden sollen.

1. Kopieren Sie die Links/Tags in einen Newsletter, eine Website oder ein Kundenzentrum, um das Formular für Kunden oder Interessenten zu veröffentlichen.

![Registerkarte "Veröffentlichen" in SuperOffice Marketing, die zeigt, wie Sie eine Veröffentlichungsoption auswählen und Formularfelder mit Kontaktdaten vorausfüllen. -screenshot][img3]

## <a id="prefill"></a>Vorausfüllen von Feldern in Formularen

Sie können ausgewählte Formularfelder mit vorhandenen Kundendaten aus SuperOffice vorausfüllen, um Besuchern Zeit beim Absenden eines Formulars zu sparen.

Wenn Sie ein oder mehrere Felder im Abschnitt **Mit Kontaktdaten vorausfüllen** auswählen, fügt SuperOffice die entsprechenden Feldbezeichner und [Vorlagenvariablen][7] dem Link oder Skript-Tag hinzu.

Wenn das Formular geöffnet wird, werden diese Felder automatisch mit den gespeicherten Informationen des Kunden ausgefüllt.

Ein **Feldbezeichner** ist eine eindeutige ID für ein bestimmtes Feld. Er ändert sich nicht, selbst wenn sich der Feldname, das Label oder die Sprache ändern.

Zum Beispiel:

```text
...form&id=F-Rg2nDAQI
```

wird zu:

```text
...form&id=F-Rg2nDAQI&field_Email%3A=[[urlEncode(customer.email)]]
```

Dies stellt sicher, dass das Formular die E-Mail-Adresse jedes Kontakts dynamisch einfügt, wenn es über einen personalisierten Link geöffnet wird.

> [!TIP]
> Feldbezeichner sind sprachübergreifend und über Aktualisierungen hinweg stabil, sodass Ihre Links auch dann weiterhin funktionieren, wenn das Formular später bearbeitet wird.

## <a id="utm"></a>UTM-Tracking hinzufügen (Marketing Premium)

Der integrierte **UTM-Builder** erstellt einen Formularlink mit [UTM-Parametern][4], damit SuperOffice nachvollziehen kann, woher Ihre Leads kommen, wenn ein Besucher das Formular absendet.

### Voraussetzungen und Einschränkungen

* Sie haben einen **Marketing Premium**-Benutzerplan.
* Ein Administrator hat [die Übertragung von UTM-Daten für Formularübermittlungen aktiviert][6].
* UTM-Tracking ist nur für die Option **Direkter Link** verfügbar. Es gilt nicht für eingebettete Formulare.

### Schritte

1. Wählen Sie im Tab **Veröffentlichen** die Option **Direkter Link** als Veröffentlichungsmethode.

1. Geben Sie im Abschnitt **UTM-Tracking hinzufügen** einen oder mehrere UTM-Werte ein, z. B. **Quelle**, **Medium** und **Kampagne**.

    Zum Beispiel:

    ```text
    ...form&id=F-Rg2nDAQI
    ```

    wird zu:
    ```text
    ...formId=F-Rg2nDAQI&utm_source=linkedin&utm_campaign=rebranding
    ```

    ![UTM-Tracking-Felder in der Formularveröffentlichungsansicht -screenshot][img4]

    Weitere Informationen zu den einzelnen Parametern und Benennungskonventionen finden Sie unter [UTM-Parameter][4].

1. Kopieren Sie den generierten Link aus dem Feld unten.

1. Fügen Sie den Link in Ihre Anzeige, E-Mail oder Ihren Social-Media-Beitrag ein.

> [!TIP]
> Kopieren und speichern Sie den Link sofort nach der Erstellung. Spätere Änderungen an den Feldern erzeugen einen neuen Link.

## Was geschieht jetzt?

Eine Benachrichtigung auf der Registerkarte **Formularübermittlungen** zeigt an, dass Sie [Formular Angaben erhalten haben][2], die möglicherweise [manuell verarbeitet werden müssen][3].

Formulare können manuell deaktiviert werden oder werden automatisch deaktiviert, wenn ein bestimmtes Datum erreicht ist oder eine bestimmte Anzahl von Angaben erhalten ist.

## Verwandte Inhalte

* [Übersicht über Conversion-Tracking][5]
* [UTM-Tracking einrichten][6] - in Einstellungen und Verwaltung

<!-- Referenced links -->
[2]: view-statistics.md
[3]: process-submissions.md
[4]: ../../utm/learn/parameters.md
[5]: ../../utm/learn/index.md
[6]: ../../utm/admin/set-up.md
[7]: ../../../knowledge-base/learn/reply-templates/template-variables.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/marketing/form-publish.png
[img4]: ../../../../media/loc/en/marketing/utm-builder.png
