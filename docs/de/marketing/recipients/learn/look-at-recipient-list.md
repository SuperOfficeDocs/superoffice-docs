---
uid: help-de-mailing-recipient-list
title: Nach der Kampagne mit der Empfängerliste arbeiten
description: Nach der Kampagne mit der Empfängerliste arbeiten
keywords: Marketing, Empfänger
author: SuperOffice Product and Engineering
date: 02.27.2024
version: 10
content_type: howto
language: de
audience: person
audience_tooltip: SuperOffice Marketing
---

# Nach der Kampagne die Empfängerliste ansehen

Nach dem Versand Ihrer Kampagne ist es immer wieder spannend zu sehen, wie gut Ihre Kampagne funktioniert hat. Es ist auch eine großartige Gelegenheit, die Qualität der in Ihrer Datenbank erfassten Informationen zu überprüfen und zu verbessern. Ein wichtiger Indikator ist vor allem die Anzahl der unzustellbaren E-Mails. In dieser Anleitung lernen Sie, wie Sie Ihre Empfängerliste filtern können.

Nach dem Senden der Kampagne sammelt SuperOffice Marketing Daten über den Status jeder gesendeten E-Mail. In der Registerkarte Empfänger können Sie den Status für jeden einzelnen Empfänger der Kampagne ansehen. Darüber hinaus können Sie die Liste filtern und die Ergebnisse zur weiteren Bearbeitung zu Selektionen und Projekten in SuperOffice CRM exportieren.

![Sie können den Status der Kampagne im Feld Status sehen -screenshot][img4]

## Schritte

1. Klicken Sie auf der Registerkarte **Kampagnen** auf die Kampagne.

2. Klicken Sie auf die Ansicht **Kampagne anzeigen** auf die Registerkarte **Empfänger**.

    Die Liste zeigt die ersten 100 Empfänger. Klicken Sie auf <i class="ph ph-arrow-right" aria-label="Arrow right"></i>, um die nächsten 100 anzuzeigen.

3. Führen Sie die Option [Liste filtern](#filters) aus, indem Sie das Kontrollkästchen unten in der Liste anwählen.

    Standardmäßig sind zur Anzeige aller Empfänger sämtliche Filter aktiviert. Entfernen Sie das Häkchen aus dem Kontrollkästchen, um den Filter zu deaktivieren. Es können mehrere Filter kombiniert werden.

4. Verwenden Sie die Kontrollkästchen in der linken Spalte, um alle oder einzelne Empfänger auszuwählen.

5. Klicken Sie auf die Schaltfläche Menü **Actionen**. Sie haben hier die folgenden Optionen:
    * Ausgewählte Empfänger in eine Excel-, HTML- oder Textdatei exportieren.
    * [Ausgewählte Empfänger einer neuen oder vorhandenen Selektion bzw. einem Projekt hinzufügen](#add-recipients).
    * Die Kampagne erneut an die ausgewählten Empfänger senden.

6. Klicken Sie auf **Schließen**, um die Ansicht **Kampagne anzeigen** zu schließen.

Beim Status **Für den Versand bereit** brauchen Sie nichts zu tun. SuperOffice sendet Ihre Kampagne an die Empfänger. Danach ändert sich der Status in **Gesendet** .

## <a id="filters"></a>Filter

* **Gesendet**: Aktivieren Sie diesen Filter, um alle Empfänger anzuzeigen, an die die Kampagne verschickt wurde.

* **Nicht zustellbar**: Aktivieren Sie diesen Filter, um die Empfänger anzuzeigen, an die die [Kampagne als nicht zugestellt zurückgegeben][3] wurde. Grund hierfür können fehlerhafte E-Mail-Adressen, Spamfilter, Probleme mit dem Internet oder volle Posteingänge sein.

* **Gelesen von Empfänger**: Aktivieren Sie diesen Filter, um alle Empfänger anzuzeigen, die die Kampagne geöffnet/gelesen haben.

* **Für den Versand bereit**: Aktivieren Sie diesen Filter, um die Empfänger anzuzeigen, an die die Kampagne noch nicht gesendet wurde.

* **Blockiert**: Aktivieren Sie diesen Filter, um die folgenden Empfänger anzuzeigen:

* Empfänger, die noch keine Einwilligung zur Kontaktaufnahme erteilt haben
* Doppelt vorhandene Empfänger
* [Empfänger ohne Abonnement][5]

**Empfänger hat sich beschwert**: Aktivieren Sie diesen Filter, um alle Empfänger anzuzeigen, die die Kampagne als [Spam/Junk-Mail][4] gemeldet haben.

Beim Status **Für den Versand bereit** brauchen Sie nichts zu tun. SuperOffice sendet Ihre Kampagne an die Empfänger. Danach wird der Status in **Gesendet** geändert.

<!-- markdownlint-disable-next-line MD013 -->
## <a id="add-recipients"></a>Empfänger Selektionen oder Projekten hinzufügen

Über die Menüschaltfläche **Actionen** können Sie Empfänger und Klicker zu einer Selektion oder einem Projekt hinzufügen.

> [!NOTE]
> Es werden ausschließlich Personen zur Selektion oder zum Projekt hinzugefügt, die in der Datenbank von SuperOffice erfasst sind. Ein Personensymbol (<i class="ph ph-user-circle" aria-hidden="true"></i>) in der Spalte **Typ** gibt an, dass eine Person in der Datenbank von SuperOffice erfasst ist. Empfänger, die aus externen Listen importiert worden sind, werden in der Regel nicht erfasst.

### Klicker einer neuen oder vorhandenen Selektion bzw. einem Projekt hinzufügen

1. Wählen Sie die entsprechenden Personen aus der Liste aus.
2. Klicken Sie auf die Schaltfläche Menü **Actionen**.
3. Klicken Sie auf **Zu neuer Selektion hinzufügen** oder **Zu neuem Projekt hinzufügen**.
4. Geben Sie den Namen der neuen Selektion bzw. des neuen Projekts ein.
5. Klicken Sie auf **OK**.

### Klicker einer vorhandenen Selektion bzw. einem vorhandenen Projekt hinzufügen

1. Wählen Sie die entsprechenden Personen aus der Liste aus.
2. Klicken Sie auf die Schaltfläche Menü **Actionen**.
3. Klicken Sie auf **Zu vorhandener Selektion hinzufügen** oder **Zu vorhandenem Projekt hinzufügen**.
4. Beginnen Sie mit der Eingabe des Namens der gesuchten Selektion bzw. des Projekts.
5. Klicken Sie auf eine Selektion oder ein Projekt in der Liste.
6. Klicken Sie auf **OK**.

Öffnen Sie die Selektion bzw. das Projekt und überprüfen Sie, ob die Personen hinzugefügt wurden.

## Verwandte Themen

* [Nach der Kampagne mit überwachten Links arbeiten][1]

<!-- Referenced links -->
[1]: ../../tracked-links/learn/explore-clicks.md
[3]: manage-bounces.md
[4]: spam-complaints.md
[5]: manage-email-subscriptions.md

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/marketing/recipients-tab-status.png
