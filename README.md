# RadekPA
project created by RadekRo to help codecool students to prepare to PA on C#

1. Człowiek

Każdy człowiek ma:
a) imię
b) nazwisko
c) płeć
d) wiek

2. Pracownik

Każdy pracownik jest człowiekiem, a dodatkowo posiada:

a) pracodawcę (firmę w jakiej pracuje)
b) stanowisko (storage worker, desktop worker, driver)
c) wynagrodzenie (w tejże firmie)
d) staż pracy
e) umiejętności (skill level) w wysokości losowej od 0 do 30;

Każdy kierownik jest pracownikiem, a dodatkowo posiada:

a) premię roczną
b) służbowy laptop - 1 sztuka
c) służbowy telefon - 1 sztuka
d) stanowisko - kierownik
e) lojalność losową od 2 do 10.

Każdy Specjalista jest pracownikiem, a dodtkowo posiada:

a) losowy poziom umiejętności, tzw. Skill level na poziomie od 50 do 100.
b) ubezpieczenie medyczne w kwocie 2000 EUR
c) kartę multisport w ilości 1 sztuki.


Scenariusze:

1) Każdy człowiek potrafi podać swoje imię i nazwisko oraz wiek.
2) Każdy pracownik potrafi się przedstawić tak jak człowiek podając dodatkowo firmę w jakiej pracuje i swoje stanowisko służbowe.
3) Każdy pracownik otrzymuje podwyżkę wynagrodzenia w wysokości 10% swojej aktualnej pensji oraz +10 do poziomu skill level - po przepracowaniu 2 lat.
4) Każdy pracownik którego skill level przekroczy 50 będzie się domagał awansu na specjalistę (Hey! I don't wont to be an ordinary worker anymore. Make me a specialist!).
5) Każdy pracownik potrafi obliczyć kiedy może liczyć na awans na specjalistę i podać to w formie: "Mogę być specjalistą w ciągu X lat."
5) Każdy kierownik będzie podawał poziom swojej lojalności (I am loyal at X points level :) )
6) Specjalista, którego skill przekroczy 100 będzie się domagał awansu na kierownika (Hey, I need to be a manager now! Make me one or I am leaving!)
7) każdy specjalista, który zgubi kartę multisport będzie się domagał jej ponownie (Hey! I lost my multisport card. I want a new one!) do momentu jej otrzymania.
8) Kierownik może co roku zmieniać lojalność o 1 pkt w górę lub w dół (losowo). Jeśli lojalność kierownika spadnie poniżej 2 pkt - odchodzi z firmy. Od tego momentu wyświetla stały komunikat. I don't care I don't work here anymore!

Operacje wymagane na poziomie program.cs w klasie main:

1) stwórz parę ludzi.
2) stwórz 3 pracowników.
3) stwórz jednego specjalistę.
4) stwórz jednego kierownika.
5) wywołaj metodę ToString u jednego z dwóch ludzi.
6) wywołaj metodę ToString i jednego z pracowników.
7) wywołaj metodę ToString u kierownika.
8) dodaj staż pracy dowolnego pracownika (+7 lat).
9) wywołaj metodę ToString u tego pracownika
10) Dodaj specjaliście +50 do skilla
11) wywołaj metodę ToString specjalisty.
12) podaj staż pracy wszystkich pracowników w formie (Jestem {imię}. Pracuję tu {staż} lat.
13. Specjalista gubi kartę multisport.
14. Wywołaj metodę ToString ze specjalisty.
15. Specjalista otrzymuję nową kartę multisport.
16. Wywołaj metodę ToString u specjalisty.
17. Podaj imię i nazwisko najstarszego pracownika (The eldest worker is {name} {family name}. He is {age} years old!
18. Każdy pracownik podaje czas w jakim może stać się specjalistą w formie: 
Mam na imię {imię} - specjalistą stanę się za X lat.
19. Kierownik przepracowuje 5 lat. 
20. Wywołaj metodę ToString u kierownika.

Każdy krok powinien być widoczny po uruchomieniu aplikacji w postaci:
Krok 1 
Krok 2
Krok 3
Jeśli krok kończy się wywołaniem metody ToString powinien wyświetlić się odpowiedni komunikat, np.
Krok 4
Hey I want my money back!

Kod powinien uwzględniać dziedziczenie, zasadę clean code i najważniejsze DRY (DO NOT REPEAT YOURSELF). Jeśli możesz załatwić coś metodą wirtualną i potem dokonać jej nadpisania - zrób to.

Czas: 75 minut 20:10 do 21:25. PRACA SAMODZIELNA!
UWAGA - Program piszemy od ZERA. Nie ma żadnego repozytorium.
