---
uid: help-de-languages-add
title: Mit Kundensprachen arbeiten
description: "In dieser Anleitung lernen Sie, wie Sie Kundensprachen festlegen."
author: SuperOffice RnD
date: 06.29.2022
keywords: Sprache
content_type: howto
language: de
---

# Wie man Kundensprachen erstellt und bearbeitet

## So fügen Sie Kundensprachen hinzu

1. [!include[Go to Options](../includes/open-options.md)]

2. Wählen Sie die Registerkarte **Kundensprachen** aus.

3. Klicken Sie auf die Schaltfläche **Neue Kundensprache**. Sie gelangen zur Ansicht **Eigenschaften der Kundensprache**.

    ![Sie können eine neue Sprache im Dialogfeld Eigenschaften der Kundensprache einrichten -screenshot][img1]

4. Geben Sie im Feld **Name** den Namen der Sprache ein, die als Bezeichnung in den Sprachen-Auswahlfeldern verwendet werden soll.

5. Geben Sie im Feld **Sprachcode** eine kurze Bezeichnung für die betreffende Sprache (oder ein Äquivalent) ein. Normalerweise werden die internationalen zwei-Buchstaben-Abkürzungen verwendet (z.B. DE, DK, EN, NL, NO und SE). Eine vollständige Liste finden Sie am Ende dieser Seite.

6. Geben Sie im Feld **Virtuelle Domäne** die Domänenadresse für den Zugriff auf das SuperOffice Kundenzentrum in der betreffenden Sprache ein, wie zum Beispiel germany.liberty.com. Solche Domains müssen im Voraus eingestellt werden.

7. Geben Sie im Feld **E-Mail-Domäne** eine Liste mit E-Mail-Domänen ein (jeweils durch ein Komma getrennt), wie zum Beispiel: no, se, co.uk. Wenn eine neue Person automatisch erfasst wird (durch den Import einer E-Mail) und ihre E-Mail-Adresse eine dieser Domänen enthält, wird automatisch diese Sprache ausgewählt.

8. Im Feld **FAQ-Ordner** wählen Sie den obersten Ordner aus, der in der FAQ-Hierarchie für Besucher des SuperOffice Kundenzentrum in der jeweiligen Sprache ganz oben stehen sollte. Dadurch kann die FAQ-Hierarchie in mehrere unterschiedliche Sprachabschnitte aufgeteilt und dann nach Sprache gefiltert werden. Dies bietet bessere Suchergebnisse, und für den Benutzer werden nur FAQs in der entsprechenden Sprache angezeigt.

9. Aktivieren Sie die Option **Als Standard verwenden**, wenn Sie diese Sprache als Standardsprache festlegen möchten. Diese Sprache wird verwendet, wenn keine andere Kundensprache den Kriterien entspricht oder wenn keine Sprache für einen Kunden definiert wird.

10. Klicken Sie auf **OK**. Die Kundensprache wird erstellt und [externe Kategorien][1] können erstellt werden.

    > [!TIP]
    > Sie können die Kundensprache für andere Elemente als Sprache verwenden, wenn Sie zum Beispiel nur in einem Land tätig sind. Sie können beispielsweise unterschiedliche Abteilungen, Branchen oder Gewerbe wie Bauwesen, Badezimmer, Einrichtung und Gärten erstellen. Dann können das SuperOffice Kundenzentrum, die FAQ-Hierarchie und die Antwortvorlagen den Bereich widerspiegeln, der für die jeweiligen Kunden relevant ist. Die für die Abteilung verwendete Abkürzung muss den Ordnernamen im Ordner \\templates widerspiegeln. Zum Beispiel: Bauwesen = BW.

## Sprachcodes

| Sprache | Code |
|---|:-:|
| Chinesisch (vereinfacht) | CN |
| Tschechisch | CZ |
| Dänisch | DA (nicht DK) |
| Niederländisch | NL |
| Englisch | EN |
| Finnisch | FI |
| Französisch | FR |
| Deutsch | DE |
| Deutsch (Schweiz) | CH |
| Italienisch | IT |
| Koreanisch | KO |
| Norwegisch | NO |
| Polnisch | PL |
| Portugiesisch (Brasilien) | BR |
| Russisch | RU |
| Spanisch | ES |
| Schwedisch | SE (nicht SV) |
| Ukrainisch | Großbritannien |
| Vietnamesisch | VI |

## Worüber würden Sie gern mehr erfahren?

* [Wie SuperOffice die Kundensprache für neue Personen auswählt][2]

<!-- Referenced links -->
[1]: ../../../../request/admin/category/external-categories.md
[2]: index.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/customer-centre-language.png
