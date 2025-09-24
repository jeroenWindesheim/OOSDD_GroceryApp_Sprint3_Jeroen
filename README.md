# GroceryApp sprint3 Studentversie  
    
## UC07 Delen boodschappenlijst  
Is compleet  
  
## UC08 Zoeken producten  
Aanvullen:
- In de GroceryListItemsView zitten twee Collection Views, namelijk één voor de inhoud van de boodschappenlijst en één voor producten die je toe kunt voegen aan de boodschappenlijst  
- Voeg boven de tweede CollectionView een zoekveld (SearchBar) in om op producten te kunnen zoeken.  
- Zorg dat de SearchCommand wordt gebonden aan een functie in het onderliggende ViewModel (GroceryListItemsViewModel) en dat de zoekterm die in het zoekveld is ingetypt gebruikt wordt als parameter (SearchCommandParameter).  
- Werk in het viewModel (GroceryListItemsViewModel) de zoekfunctie uit en zorg dat de beschikbare producten worden gefilterd op de zoekterm!  

## UCx Registratie gebruiker 
Of een ander idee zelf uitwerken. Dit betekent ook dat de documentatie hiervoor ontwikkeld moet worden.


## Gitflow
- - - 
Voor deze repository wordt **GitFlow** gebruikt om het ontwikkelproces te structureren en overzichtelijk te houden.

### Branches

-  **`main`**
    - Bevat de stabiele code die volledig getest en gereed is voor productie.
    - Alleen code die via `develop` is goedgekeurd komt uiteindelijk in `main`.


- **`develop`**
    - Hier staat de code die klaar is om getest te worden en als basis dient voor nieuwe features.


- **`feature/naam_van_feature`**
    - Voor elke use case of nieuwe feature wordt een aparte feature branch aangemaakt vanaf `develop`.
    - Na afronding wordt de feature branch terug gemerged naar `develop`.
    - **Belangrijk:** wanneer een feature branch volledig gemerged is, moet deze verwijderd worden om de repository schoon te houden.


### Branch / Commit / Merge Request Conventies
Om ervoor te zorgen dat de github repository overzichtelijk blijft, zijn de volgende naming conventies van kracht:

- Branches:
    - `feature/naam_van_feature`
    - `bugfix/naam_van_bugfix`
    - `hotfix/naam_van_hotfix`


- Commit
    - Geef een duidelijke omschrijving van de commit.


- Merge Request
    - Geef een duidelijke omschrijving van de Merge Request (Pull Request)
    - Assign jezelf als Assignee
    - De reviewer moet de code reviewen en goedkeuren