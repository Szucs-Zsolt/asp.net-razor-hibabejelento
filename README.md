# asp.net-razor-hibabejelento
ASP.NET Core Razor pages példa, egyszerű hibabejelentő oldalra

Főoldal (Felhasználónak): 
- A felhasználó megadja az adatait.
- Az adatok érvényességét (pl. érvényes telefonszám forma) ellenőrizzük.
- Hozzá kell járulnia az adatai kezeléséhez.
- Ezután a hibajegyet lementjük az adatbázisba.
- Megadjuk a felhasználónak a hibajegy számát, amire hivatkozhat később.

Ügyfélszolgálat:
- Kiválasztja a következő kezelendő hibajegyet, lezárja.
- A hibajegyek 10 másodpercenként frissülnek.
- Lehetőség van lezárt hibajegyek újboli megnyitására.
