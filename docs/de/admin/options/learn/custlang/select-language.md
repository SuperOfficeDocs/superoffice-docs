---
uid: help-de-languages-selection
title: Kundensprache für neue Personen
description: Wie SuperOffice die Kundensprache für neue Personen auswählt
author: SuperOffice RnD
date: 06.29.2022
keywords: Sprache
content_type: howto
language: de
---

# Wie SuperOffice die Kundensprache für neue Personen auswählt

Wenn eine neue Person eine Anfrage einsendet, versucht SuperOffice zu entscheiden, welche Kundensprache für die Person angezeigt werden soll.

## Szenario 1

1. John, eine neue Person, registriert eine neue Anfrage im Kundenzentrum cs.liberty.com mit der E-Mail-Adresse `john@coca-cola.se`.

2. Die neue Anfrage wird an das System gesendet, wo Johns E-Mail-Domäne (coca-cola.se) geprüft wird. coca-cola.se ist als Domäne für die Firma Coca-Cola erfasst.

3. John wird als eine neue Person für Coca-Cola hinzugefügt, nicht als neue Person ohne Firma.

4. SuperOffice prüft dann, ob die E-Mail-Domäne .se mit einer der erfassten Kundensprachen verknüpft ist. .se ist als Domäne für die Kundensprache Schwedisch erfasst.

5. Für John wird daher Schwedisch als Kundensprache festgelegt.

6. SuperOffice sendet John eine schwedische Antwortvorlage (wenn diese erstellt wurde) und informiert ihn darüber, dass die Anfrage erhalten und erfasst wurde.

7. John erhält einen Benutzernamen und ein Passwort von SuperOffice und kann sich damit bei cs.liberty.com einloggen und auf die schwedische Version vom SuperOffice Kundenzentrum zugreifen. John erhält auch Zugriff auf schwedische FAQs, wenn dies in SuperOffice festgelegt wurde.

## Szenario 2

1. Maria, eine neue Person, registriert eine neue Anfrage im Kundenzentrum cs.liberty.com mit der E-Mail-Adresse `maria@coca-cola.nl`.
2. SuperOffice prüft die E-Mail-Domäne und diese wird für die Firma Coca-Cola erfasst.
3. Maria wird als neue Person für Coca-Cola hinzugefügt.
4. Dann prüft SuperOffice, ob die E-Mail-Domäne .nl mit einer der erfassten Kundensprachen verknüpft ist. Die E-Mail-Domäne .nl ist *nicht* mit einer Kundensprache verknüpft, sodass für Maria keine Kundensprache festgelegt werden kann.
5. Maria erhält eine Antwortvorlage in der Standardsprache für ihre Firma. Das SuperOffice Kundenzentrum und die FAQs werden ebenfalls in der Standardsprache angezeigt.

## Szenario 3

1. Niederländisch wird als neue Kundensprache in SuperOffice hinzugefügt und mit der Domäne .nl verknüpft.
2. Maria erhält nicht automatisch Niederländisch als Kundensprache. Sie muss der Person manuell zugewiesen werden. Nur neue Personen werden auf neue Kundensprachen geprüft.
