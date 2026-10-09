# FCManager

## Purpose
Aplikacja do zarz¹dzania kadr¹ klubu pi³karskiego, umo¿liwiaj¹ca zarz¹dzanie zawodnikami oraz ich statystykami.

## Main Features
- Zarz¹dzanie zawodnikami
- Statystyki dru¿yny i zawodników

## Users & Roles
- Trener: zarz¹dza sk³adem, dodaje zawodników, przegl¹da statystyki
- Asystent trenera: przegl¹da sk³ad i statystyki

## Technologies
- Backend: C#, ASP.NET Core
- Frontend: Blazor/React
- Database: SQL Server

## Sample User Story
Jako trener chcê dodaæ nowego zawodnika, aby mieæ aktualny sk³ad dru¿yny.

## User Stories

### Dyrektor sportowy
1. Dodaje nowego zawodnika.
2. Edytuje dane zawodnika.
3. Usuwa zawodnika.
4. Dodaje nowy kontrakt zawodnikowi.
5. Przegl¹da historiê kontraktów zawodnika.
6. Edytuje szczegó³y kontraktu zawodnika.
7. Koñczy kontrakt zawodnika.
8. Przenosi zawodnika do archiwum po zakoñczeniu kontraktu.

### Trener
9. Dodaje notatki do profilu zawodnika.
10. Wprowadza informacjê o kontuzji zawodnika.
11. Dodaje, edytuje i usuwa kartki zawodnika.
12. Przypisuje numery na koszulkach zawodnikom.
13. Przypisuje zawodników do pozycji na boisku.
14. Uzupe³nia formularz meczowy o dane meczowe (czas gry, bramki, asysty, ocena, inne statystyki).
15. Wybiera sk³ad meczowy na dany mecz.
16. Generuje plik ze sk³adem meczowym.

### Asystent trenera
17. Dodaje notatki do profilu zawodnika.
18. Wprowadza informacjê o kontuzji zawodnika.
19. Dodaje, edytuje i usuwa kartki zawodnika.
20. Uzupe³nia formularz meczowy o dane meczowe.

### Wszyscy u¿ytkownicy
21. Przegl¹daj¹ listê wszystkich zawodników.
22. Filtrowanie zawodników wed³ug pozycji.
23. Wyszukiwanie zawodników po nazwisku.
24. Przegl¹danie statystyk zawodnika.
25. Przegl¹danie historii zmian w profilu zawodnika.
26. Eksportowanie listy zawodników do pliku.
27. Przegl¹danie sk³adu dru¿yny.
28. Przegl¹danie raportów statystycznych dla dru¿yny.
29. Przegl¹danie formularzy meczowych i statystyk meczowych.

## Model danych – kontrakty i kartki

- **Kontrakt**: osobny obiekt powi¹zany z zawodnikiem, zarz¹dzany przez dyrektora sportowego. Zawiera m.in. datê rozpoczêcia, zakoñczenia, status, wynagrodzenie.
- **Kartka**: osobny obiekt powi¹zany z zawodnikiem, zarz¹dzany przez trenera i asystenta trenera. Zawiera typ (¿ó³ta/czerwona), datê, powód, status (odbyta/nieodbyta).

## Nowe funkcjonalnoœci

- **Formularz meczowy**: Umo¿liwia uzupe³nianie danych dotycz¹cych udzia³u zawodników w meczu (czas gry, bramki, asysty, ocena, inne statystyki) przez trenera i asystenta trenera.
- **Wybór sk³adu meczowego**: Pozwala trenerowi wybraæ sk³ad na mecz oraz wygenerowaæ plik (np. PDF, CSV) ze sk³adem.

### Kwestie bardziej techniczne

## DDD
W aplikacji zastosowano Domain Drive Development.

**:star: KAZIO ZRÓB Z TEGO KURS NA PLURALSIGHT :star:**

## Architektura Aplikacji
FCManager.sln
- FCManager.Domain
- FCManager.Application
- FCManager.Infrastructure
- FCManager.API