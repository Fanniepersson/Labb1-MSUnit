# Labb2-MSUnit
My first MSUnit test program


Jag har valt ut tre delar av programmet som har affärskritiska delar, det är följande:

1. Överföring av pengar mellan konton
2. Insättning av pengar
3. Uttag av pengar


### Följande saker som kan gå fel i överföring  av pengar mellan konton:
* Skriva in konto nummer med bokstäver (endast siffror är tillåtna)
* Skriva in ett konto nummer som ej existerar
* Skriva in samma konto nummer som man valt att föra över pengar från (går inte att flytta pengar från och till samma konto)
* Skriva in summan med bokstäver
* Skriva in en summa på 0 kr eller lägre
* Skriva in en summa högre än man har på kontot som man ska flytta pengarna ifrån

### Följande saker som kan gå fel i insättning av pengar:
* Skriva in konto nummer med bokstäver
* Skriva konto nummer som ej existerar
* Skriva in summan med bokstäver
* Skriva in en summa på 0 kr eller lägre

### Följande saker kan gå fel vid uttag av pengar:
* Skriva in konto nummer med bokstäver (endast siffror är tillåtna)
* Skriva in ett konto nummer som ej existerar
* Skriva in summan med bokstäver
* Skriva in en summa på 0 kr eller lägre
* Skriva in en summa högre än man har på sitt konto man ska göra uttaget ifrån
