---
uid: help-de-edit-email-signature
title: Signaturen bearbeiten
description: So bearbeiten Sie E-Mail-Signaturen und Anfrage-Signaturen
keywords: Signatur bearbeiten, E-Mail-Signatur, Anfrage-Signatur, Persönliche Signatur, Signatur
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Signaturen bearbeiten

Die standardmäßigen Vorlagen enthalten Vorlagenvariablen, die mit Daten aus SuperOffice ersetzt werden. Dadurch bleiben Ihre Signaturen immer mit den richtigen Informationen aktuell.

* **E-Mail-Signatur:** Die Vorlage enthält Variablen für Ihren Namen, Ihre Firma, Ihre Adresse, Telefonnummern, E-Mail-Adresse, Website usw. [aus Ihrer Personenkarte][3].

* **Anfrage-Signatur:** Die Vorlage enthält Variablen für Ihren Namen, Ihre Firma, Ihre E-Mail-Adresse usw., die spezifisch für [Antwortvorlagen][2] sind.

> [!NOTE]
> Sie können diese beiden Sätze von Vorlagenvariablen nicht kombinieren. Zusätzlich können persönliche Signaturen nicht von Administratoren überschrieben werden.

## Schritte

1. Klicken Sie auf die Schaltfläche **Persönliche Einstellungen** (<i class="ph ph-user-circle" aria-hidden="true"></i>) in der oberen Leiste.

1. Wählen Sie **Persönliche Signatur bearbeiten**.

1. Wählen Sie im Dialogfeld entweder die Registerkarte **E-Mail-Signatur** oder die Registerkarte **Anfrage-Signatur**.

1. Bearbeiten Sie den Text und fügen Sie weiteren Inhalt hinzu.

    * Klicken Sie auf **[v]** in der Symbolleiste, um Variablen hinzuzufügen, oder gehen Sie zu den oben verlinkten Referenzen für die vollständige Liste der verfügbaren Variablen.

    * Fügen Sie Bilder und Links über die Schaltflächen in der Symbolleiste hinzu. Sie können auch Links und Bilder per Drag-and-Drop einfügen. Wählen Sie **Link einfügen**, um Links zu relevanten Ressourcen oder sozialen Medien hinzuzufügen.

    ![Persönliche Signatur bearbeiten -screenshot][img1]

1. Klicken Sie auf **Speichern**, wenn Sie fertig sind.

1. Optional: Testen Sie die Signatur, indem Sie eine E-Mail an sich selbst senden (für E-Mail-Signaturen) oder eine neue Anfrage erstellen (für Anfrage-Signaturen). Überprüfen Sie, ob alle Informationen korrekt angezeigt werden, Links funktionieren und Bilder richtig dargestellt werden.

## Beispiel

Dies ist ein Beispiel für eine Signatur, die jeder in Ihrer Firma verwenden kann.

```text
Mit freundlichen Grüßen
{auth}
{atit}
{onam}
Adresse: {opad}, {ozip} {ocit}
Telefon: {audp}
Mobiltelefon: {aupc}
{auem}
{owww}

Mit freundlichen Grüßen,
John Jones
Sales Manager
SuperShop
Adresse: High Street 12, 223-344, Springfield
Telefon: 22334455
Mobiltelefon: 99887766
jj@supershop.com
supershop.com
```

## Verwandte Themen

* [Standard-E-Mail-Client in SuperOffice ändern][1]

<!-- Referenced links -->
[1]: ../../email/learn/change-default-mail-client.md
[2]: ../../request/reply-templates/learn/template-variables.md
[3]: ../../document/templates/variables/for-selected-contact.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/learn/getstarted-preferences-email-signature.png
