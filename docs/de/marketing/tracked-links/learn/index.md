---
uid: help-de-mailing-tracked-links
title: Überwachte Links
description: "Ein in eine Kampagne eingefügter Link kann verwendet werden, um die Antworten Ihrer Kunden und Interessenten zu verfolgen. Wenn die Empfänger Ihrer Kampagne auf den Link klicken, wird eine Aktion ausgelöst." 
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Marketing
so.topic: concept
language: de
---

# Überwachte Links

[!include[Requirement](includes/req-marketing.md)]

Das Ziel Ihres Newsletters oder Ihrer E-Mail-Kampagne bestimmt, welche Links Sie verwenden sollten. Jedes Ziel hat ihre eigenen Handlungsanreize, um eine Antwort des Empfängers auszulösen, den Sie verfolgen möchten. Auf diese Weise können Sie Ihre Empfänger nachverfolgen, nachdem Sie alle Ergebnisse erhalten haben.

Wenn Sie zum Beispiel auf einen Link klicken, wird möglicherweise eine neue Website geöffnet oder die Personenkarte des Empfängers aktualisiert. Die Aktion kann auch eine Serviceanfrage in Service und auf der Bereichsregisterkarte Anfrage in der Personenkarte hinzufügen. Die Verwendung von Links ist nur für Benutzer verfügbar, die den Marketingplan abonniert haben.

Bevor Sie mit der eigentlichen Kampagne beginnen, können Sie die Links einrichten, die Sie häufig in Ihren Kampagnen verwenden werden. Nachdem Sie sie eingerichtet haben, können Sie sie immer wieder verwenden, um Zeit zu sparen. Die gebräuchlichsten Links sind zum Beispiel:

* Abmeldeseiten
* Kontaktformulare
* Social-Media-Kanäle

![In der Anzeige Link-Eigenschaften können Sie Links hinzufügen, die Sie verfolgen möchten -screenshot][img4]

Sie können Links (URLs) in eine Nachricht aufnehmen und überwachen. Mit anderen Worten ausgedrückt können Sie feststellen, wie viele Empfänger auf die Links geklickt haben.

Die URLs der einzelnen Empfänger muss eindeutig sein. So können Sie sicher sein, dass es verschiedene Empfänger waren, die auf die Links geklickt haben, und nicht ein und derselbe Benutzer mehrmals auf die Links geklickt hat. Darüber hinaus müssen die URLs auf den SuperOffice-Server verweisen, damit sie gezählt werden können, bevor sie an die Ziel-URL weitergeleitet werden. Das Programm führt diese Vorgänge automatisch aus, wenn Sie die URLs in der Nachricht auswählen, die Sie überwachen möchten.

Auf der Registerkarte **Überwachte Links** stehen folgende Optionen zur Verfügung:

| Symbol | Option | Weiterlesen |
|---|---|---|
| ![Symbol][img2] | Nachricht | [Neuen Link erstellen][1] |
| ![Symbol][img3] | Ordner hinzufügen | Für Ihre Links einen [Ordner erstellen][5] |
| Link | Klicken Sie auf einen Link, um die Ansicht **Link anzeigen** zu öffnen. | [Nach der Kampagne mit überwachten Links arbeiten][2] |
| ![Symbol][img1] | Menü | Klicken Sie auf die Menüschaltfläche neben einem Link, um mehr Optionen aufzurufen. |

Menüoptionen:

* **Ansicht**. [Wie man mit überwachten Links nach der Kampagne arbeitet][2].
* **Bearbeiten**. [Wie man überwachte Links erstellt][1].
* **Zurücksetzen**. [Wie man Zähler für Links zurückstellt][2].
* **In Ordner verschieben**. Wird verwendet, um den Link in einen anderen Ordner zu verschieben.
* **Löschen**. Löscht den Link.

## Welche Links werden verfolgt?

Wenn Sie **alle Links für eine Kampagne anzeigen** möchten, müssen Sie die Kampagne im Übersichtsmodus öffnen und die Registerkarte [Überwachte Links][4] auswählen.

## <a id="google" />Google Analytics

Beim Einrichten einer Kampagne haben Sie die Möglichkeit, Google Analytics als Tracking-System zu verwenden. Die Einrichtung in Kampagnen ermöglicht Ihnen eine genauere Nachverfolgung von E-Mails mithilfe der bereitgestellten Felder, was zu detaillierteren Google Channel-Berichten führt.

Google Analytics ist die beliebteste digitale Analysesoftware auf dem Markt. Durch die Nachverfolgung, wie Website-Besucher Ihre Website finden und nutzen, bietet der Service Ihrer Firma nützliche Erkenntnisse, die Ihnen helfen, den Erfolg Ihrer Online-Marketing-Strategien zu verbessern.

Standardmäßig identifiziert Google Analytics keine Besucher, die von bestimmten Kampagnen kommen. Sie müssen den Links in Ihrer E-Mail ein Tag hinzufügen, um Folgendes tun zu können:

* Identifizieren, auf welche Links Ihre Empfänger geklickt haben,
* Sehen, welche Website-Seiten sie besucht haben, nachdem sie auf Ihrer Website gelandet sind.

Wenn Sie in Ihrer Kampagne einen Link zu Ihrer Website ohne Tag einfügen, können Sie zwar sehen, dass Ihre Besucher von einer Kampagne kommen, wissen aber nicht von welcher. Dadurch wissen Sie nicht, wie sich die Empfänger bestimmter Kampagnen auf Ihrer Website verhalten.

Die Google Analytics-Funktion in SuperOffice Marketing identifiziert Ihre Kampagnen in den Berichten. Durch das Hinzufügen eines eindeutigen Tags zu allen Links, die Sie in Ihrer Kampagne verwenden, erkennt Google Analytics Ihre Kampagne als die Quelle an, von der die Website-Besucher kommen. Google Analytics gibt Ihnen auch einen Einblick über den Pfad, den die Besucher durch Ihre Website einschlagen.

**Medium**: „E-Mail“ ist das vordefinierte Medium in automatisierten UTM-Tags. Dies bedeutet, dass nachverfolgte Links in Kampagnen, die von SuperOffice gesendet werden, in Google Channel-Berichten unter „E-Mails“ (im Gegensatz zu „anderen“) zu finden sind.

**Quelle** und **Kampagne**: Diese Felder identifizieren diese spezifische Kampagne als Quelle und ermöglichen eine genauere Überwachung und Berichterstattung in Google.

## Zugehörige Inhalte

* [Links einfügen, die Sie überwachen möchten][3]
* [Links für Abonnement hinzufügen][4]
* [Einfache E-Mail-Überwachung mit Google Analytics][6] \- Blog
* [Verknüpfungsaktionen definieren][7]

<!-- Referenced links -->
[1]: create-links.md
[2]: explore-clicks.md
[3]: add-tracked-link-to-msg.md
[4]: ../../mailing/learn/create/add-unsubscribe-link.md
[5]: ../../learn/create-folder.md
[6]: https://community.superoffice.com/en/technical/blogs/archive/simple-google-analytics-email-tracking/
[7]: define-link-actions.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img2]: ../../../../media/icons/btn-add.png
[img3]: ../../../../../common/icons/folder.png
[img4]: ../../../../media/loc/en/marketing/link-properties.png
