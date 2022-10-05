# Labb2-MSUnit
My first MSUnit test program


Denna uppgift handlar om att skapa enhetstester (unittesting) för programvara i C#/.NET.

Jag har valt ut tre delar av programmet som har affärskritiska delar, det är följande:

1. Inloggning
2. Radera ett existerande konto
3. Insättning av pengar


### Inloggning
_i detta testet testar jag fall en användare kan logga in med fel pinkod._
* Det ska inte gå att logga in med fel kombination av användarnamn och pinkod.

### Radera ett existerande konto
_i detta kontot testar jag om det går att ta bort ett konto som jag precis lagt till._
* Det ska inte bli ett annat konto som raderas än det man anger att man vill radera.



### Insättning av pengar
_i detta testet testar jag så att pengarna hamnar på rätt konto och att pengarna överförs på rätt sätt._
* Det ska inte gå att sätta in pengar på ett annat konto än det konto man anger att man att man vill sätta in pengar på.
* Det ska inte gå att sätta in en summa som är mindre än noll kronor.

