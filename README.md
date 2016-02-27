# ShutDown
Permet de programmer des redémarrages, extinctions, déconnexions et mise en veille à une heure et à un jour précis, ou dans un délai spécifié par l'utilisateur 

J'utilise pour ça la class System.Diagnostics.Process qui me permet, avec l'éxecutable Windows "shutdown" et quelques options, de redémarrer,
éteindre ou bien fermer sa session.
Si l'utilisateur le désire, il peut programmer une tache dans le planificateur de tache Windows pour gérer un redémarrage ou un arrêt à une date
et une heure précise.
