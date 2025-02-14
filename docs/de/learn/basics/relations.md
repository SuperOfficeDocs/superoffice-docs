---
uid: help-de-company-contact-relations
title: Firmen- und Personenbeziehungen in SuperOffice CRM
description: Erfahren Sie, wie Sie Beziehungen zwischen Firmen und Personen in SuperOffice CRM anzeigen, hinzufügen und verwalten können, um komplexe geschäftliche Verknüpfungen und benutzerdefinierte Verbindungen einfacher nachzuverfolgen.
keywords: Beziehung hinzufügen, Beziehung löschen, Beziehung, Verbindung, Person, Firma
author: Bergfrid Skaara Dias
date: 02.11.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Firmen- und Personenbeziehungen in SuperOffice CRM

Beziehungen in SuperOffice CRM ermöglichen es Ihnen, Verbindungen zwischen Firmen und Personen zu erstellen. Beziehungen bestehen immer aus zwei Parteien: einer aktiven und einer passiven. Zum Beispiel: "Firma A besitzt Firma B", wobei Firma A die aktive Partei ist und Firma B die passive Partei. Dieser Leitfaden bietet einen Überblick darüber, wie Sie diese Beziehungen anzeigen, hinzufügen und verwalten können, um komplexe Strukturen, Kooperationen oder benutzerdefinierte Beziehungen Ihrer Firma einfacher nachzuverfolgen.

## Beispiele für Beziehungen

Beispiele umfassen Eigentumsstrukturen, Partnerschaftsvereinbarungen oder persönliche Beziehungen zwischen Personen.

| Typ | Aktiv | Passiv |
|---|---|---|
| Firma - Firma | Die Firma ABC arbeitet mit dem Beratungsunternehmen XYZ zusammen. | Das Beratungsunternehmen XYZ arbeitet mit der Firma ABC zusammen. |
| Firma - Person | Die Firma ABC stellt Greg Campbell (Beratungsunternehmen XYZ) ein. | Greg Campbell (Beratungsunternehmen XYZ) wird von der Firma ABC eingestellt. |
| Person - Firma | Peter Johnson ist Eigentümer der Firma ABC. | Die Firma ABC gehört Peter Johnson. |
| Person - Person | Mark Johnson (Beratungsfirma XYZ) ist der Sohn von Peter Johnson (Firma ABC). | Peter Johnson (Firma ABC) ist der Vater von Mark Johnson (Beratungsunternehmen XYZ). |

## Beziehungen anzeigen

Die Bereichsregisterkarte **Beziehungen**, die sowohl im Firmen- als auch im Personenkarten verfügbar ist, zeigt die Beziehungen zwischen der aktuellen Einheit und anderen Firmen oder Personen.

![Beziehungen (Firmenkarte) -screenshot][img2]

[!include[Spalten in der Bereichsregisterkarte Beziehungen](../includes/table-relations-tab-columns.md)]

Um mehr Details zu sehen oder Änderungen vorzunehmen, doppelklicken Sie auf eine Zeile, um die **Beziehung**-Dialog zu öffnen.

## <a id="add"></a>Beziehung hinzufügen

1. Gehen Sie zur Firmen- oder Personenkarte, bei der Sie eine Beziehung hinzufügen möchten.

1. Wählen Sie die Bereichsregisterkarte **Beziehungen**.

1. Klicken Sie auf **Hinzufügen**, um den Dialogfeld **Beziehung** zu öffnen.

    ![Beziehungen-Dialog -screenshot][img1]

1. **Parteien angeben:**

    * **Aktive:** Wählen Sie eine Firma oder eine Person aus.
    * **Passive:** Wählen Sie die andere Einheit, die an der Beziehung beteiligt ist.

1. **Beziehungstyp wählen:** Wählen Sie den Beziehungstyp, z.B. "besitzt", "angestellt bei" oder "Partner" aus der **Beziehung**-Liste. Die verfügbaren Optionen hängen davon ab, ob die Beziehung zwischen einer Person und einer Firma oder zwischen zwei Personen besteht.

    Das **Ergebnis**-Feld wird basierend auf Ihren Auswahlen automatisch aktualisiert.

1. Fügen Sie eine Beschreibung hinzu (optional): Fügen Sie bei Bedarf zusätzliche Informationen hinzu.

1. Klicken Sie auf **Speichern**, um die Beziehung zu erstellen.

## <a id="delete"></a>Beziehung löschen

1. Gehen Sie zur Bereichsregisterkarte **Beziehungen** auf der Firmen- oder Personenkarte.

1. Finden Sie die Beziehung, die Sie löschen möchten, rechtsklicken Sie darauf und wählen Sie **Löschen**.

1. In dem angezeigten Dialog klicken Sie auf **Ja**, um zu bestätigen.

## Zusätzliche Tipps

* **Dropdown-Suche:** Wenn Sie die aktiven und passiven Parteien auswählen, beginnen Sie mit der Eingabe des Namens, um die Firma oder Person schnell zu finden.

* **Beziehungstypen:** Beziehungstypen werden in den **Einstellungen und Verwaltung** definiert. Die Anpassung dieser Typen erleichtert es Ihnen, die spezifischen Bedürfnisse Ihrer Organisation widerzuspiegeln.

## Verwandte Inhalte

* [Löschen von Elementen in SuperOffice CRM][2]
* [Gruppierung von Informationen in Bereichsregisterkarten][1]
* [Objekte zur Liste Allgemein - Beziehung hinzufügen][3]
* [Benutzerdefinierte Felder in Beziehungen][4]

<!-- Referenced links -->
[1]: ../section-tabs/index.md
[2]: deleting-elements.md
[3]: ../../admin/lists/learn/adding-items-to-relation-list.md
[4]: ../../custom-objects/learn/extra-field.md#relation

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/relation.png
[img2]: ../../../media/loc/en/company/relations-detail.png
