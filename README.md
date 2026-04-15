# 📘 Séance 12 : Initiation à l'utilisation d'API REST en C# (WPF & MVVM)

## 📖 Description
Cette série d'exercices pratiques vise à maîtriser les appels HTTP, la gestion du JSON et l'intégration d'API REST dans une application WPF structurée selon le pattern **MVVM**. Chaque exercice introduit progressivement des concepts clés : requêtes `GET`, `POST`, `DELETE`, gestion des paramètres, clés d'authentification, et mise à jour dynamique de l'interface.

## 🛠️ Technologies & Concepts Clés
- **Framework** : WPF (Windows Presentation Foundation)
- **Architecture** : MVVM (Model-View-ViewModel)
- **Réseau** : `HttpClient` pour les requêtes HTTP asynchrones
- **Données** : Sérialisation/Désérialisation JSON (`Newtonsoft.Json` ou `System.Text.Json`)
- **Binding** : `ObservableCollection<T>`, `ICommand`, DataBinding

---

## 📝 Exercices

### 🔹 Exercice 01 : Faits intéressants sur les chats
**Objectif** : Comprendre les appels `GET` et afficher une donnée dans une interface WPF avec MVVM.
**Consignes** :
1. Créer un projet WPF MVVM.
2. Concevoir l'interface avec :
   - Un bouton « Nouveau fait ».
   - Une `TextBlock` pour afficher le fait récupéré.
3. Utiliser l'API : `https://catfact.ninja/fact`
4. Créer un service dédié pour consommer l'API via `HttpClient`.
5. Lier les données à l'interface via un ViewModel.

### 🔹 Exercice 02 : Recherche de livres
**Objectif** : Mettre en œuvre une recherche avec paramètres, traitement JSON et affichage en liste.
**Consignes** :
1. Interface WPF avec :
   - Une `TextBox` pour la saisie du mot-clé.
   - Un bouton « Rechercher ».
   - Une `ListView` pour afficher les résultats (titre, auteur, description).
2. Utiliser l'API : `https://openlibrary.org/`
3. Implémenter un service réseau avec `HttpClient`.
4. Afficher les résultats via DataBinding (pattern MVVM).

### 🔹 Exercice 03 : Explorer les pays
**Objectif** : Gérer des collections complexes, implémenter du tri et de la recherche dynamique.
**Consignes** :
1. Interface WPF avec :
   - Une `TextBox` de recherche.
   - Une `ComboBox` pour trier par nom ou population.
   - Une `ListView` affichant : nom, capitale, population.
2. Appel API : `https://restcountries.com/v3.1/all`
3. Désérialiser le JSON dans une `ObservableCollection<T>`.
4. Intégration complète MVVM + filtrage/tri dynamique via le ViewModel.

### 🔹 Exercice 04 : Météo d’une ville
**Objectif** : Appeler une API avec clé d'authentification, transmettre des paramètres et afficher un résultat formaté.
**Consignes** :
1. Interface WPF avec :
   - Une `TextBox` pour saisir une ville.
   - Un bouton « Obtenir la météo ».
   - Un `StackPanel` affichant température, description météo et icône.
2. Appel API : `https://api.openweathermap.org/` *(nécessite une clé API gratuite)*
3. Utiliser `HttpClient`, inclure la clé API dans les paramètres, et parcourir la réponse JSON.
4. Utiliser le DataBinding et les `ICommand` pour actualiser l’interface de manière réactive.

### 🔹 Exercice 05 : Ajouter une tâche (POST)
**Objectif** : Comprendre la sérialisation JSON et les requêtes `POST` avec interface utilisateur.
**Consignes** :
1. Interface WPF avec :
   - Des `TextBox` pour le titre, `userId` et statut.
   - Un bouton « Ajouter ».
   - Une `TextBlock` pour afficher l’ID retourné par l'API.
2. Utiliser l'API : `https://jsonplaceholder.typicode.com/todos`
3. Sérialiser le modèle en JSON avec `Newtonsoft.Json`.
4. Envoyer les données via `HttpClient.PostAsync`.
5. Gérer la réponse et les erreurs dans le ViewModel.

### 🔹 Exercice 06 : Supprimer une tâche (DELETE)
**Objectif** : Envoyer des requêtes `DELETE` et synchroniser l'interface avec les données.
**Consignes** :
1. Interface WPF avec :
   - Une `ListView` affichant des tâches (simulées ou récupérées via JSONPlaceholder).
   - Un bouton « Supprimer » associé à chaque tâche.
2. Utiliser l'API : `https://jsonplaceholder.typicode.com/todos/{id}`
3. Déclencher `HttpClient.DeleteAsync` au clic sur supprimer.
4. Retirer l'élément de la `ObservableCollection<T>` pour mise à jour automatique de l'UI.
5. Afficher un message de confirmation (succès/erreur).

---

## 🔗 Ressources Utiles
- 🌐 **Répertoire d'APIs publiques gratuites** : [public-apis/public-apis](https://github.com/public-apis/public-apis)
