# Eigen bijdrage Gus

## Samenvatting

In dit bestand beschrijf ik mijn eigen bijdrage aan het project. Ik heb mij voornamelijk bezig gehouden met het toevoegen van monitoring binnen verschillende services en functionaliteit aan de applicatie. Hiernaast heb ik mijzelf ook nog bezig gehouden met security rondom de monitoring en een bijdrage gedaan aan de documentatie van het project.

## 1. Code/platform bijdrage

Competenties: *DevOps-1 Continuous Delivery*

Ik heb mij vooral bezig gehouden met het schrijven van functionaliteit als developer voor de applicatie. Denk hierbij dan aan het toevoegen van monitoring en het kunnen inzien van gebruikte onderdelen van een onderhoud. 

Hieronder een overzicht van mijn grootste bijdrages:

1. [Toevoegen van gebruikte onderdelen en auto-onderdelen](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/673399863c4a9946eb21cbe0f9a610799c27285f)
2. [Toevoegen van monitoring aan de applicatie via Sentry](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/16ea8634ad25d53fd3c32fd5c5e857f6a8762678)

## 2. Bijdrage app configuratie/containers/kubernetes

Competenties: *DevOps-2 Orchestration, Containerization*

In het begin van het project zijn Max en Luuk bezig geweest met het opzetten van de nieuwe service API. Uiteindelijk kwamen ze er niet meer helemaal uit en heb ik hierbij geholpen. Uiteindelijk stonden de ports niet goed ingesteld en miste er nog een aantal configuraties in de Dockerfile en docker-compose.yml bestanden. Ik heb ze hierbij geholpen en samen hebben we dit opgelost (de code is gecommit onder Luuk zijn naam).

Hieronder een overzicht van mijn grootste bijdrages:

1. [Eerste fix voor Dockerfile](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/060c167769de080402c0ae8969bfb4e78d7b7a8c)
2. [Fixen van Dockerfile, docker-compose.yml voor de nieuwe service (pair programming via Luuk en met Max erbij)](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/a6fbc02acfb4a3b18a317b16a6be5dfa5c38c5a3)

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Competenties: *DevOps-1 - Continuous Delivery*, *DevOps-3 GitOps*, *DevOps-5 - SlackOps*

Ik heb mij vooral bezig gehouden met het toevoegen van monitoring aan de applicatie. Ik heb Sentry toegevoegd aan de applicatie. De webapp en elke API service hebben een apart project binnen mijn Sentry omgeving. Hierdoor wordt er al onderscheid gemaakt tussen de verschillende services. 
Ik heb ook een kleine bijdrage geleverd aan de CI/CD pipeline. Kevin heeft Nuke Build toegevoegd aan het project en aan ons laten zien wat het kan en doet, uiteindelijk heb ik naar de PR gekeken en goedgekeurd. Dit was ook vooral om te kijken of de builds getriggered werden op de master branch. Kevin heeft daarop weer fixes uitgebracht die ik later ook weer heb bekeken. 

Hieronder een overzicht van mijn grootste bijdrages:
1. [Sentry toegevoegd aan de applicatie](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/16ea8634ad25d53fd3c32fd5c5e857f6a8762678)

## 4. Onderzoek

Competenties: *Nieuwsgierige houding*

Mijn onderzochte technologie voor dit project is Sentry. [Hier](https://github.com/hanaim-devops/devops-blog-gus-theunissen/blob/main/src/met-sentry-naar-een-foutloze-toekomst/README.md) kun je mijn blogpost vinden over mijn ervaringen met het integreren van Sentry om tot een foutloze toekomst te komen.

Ik heb Sentry toegevoegd aan iedere API-service en de webapplicatie binnen ons project. Het proces had wat uitdagingen. Sentry bood een tutorial aan voor de integratie binnen een C#-applicatie, maar de instructies verwezen naar onjuiste NuGet-packages. Hierdoor moest ik zelfstandig op zoek gaan naar de juiste dependencies. Dit is uiteindelijk gelukt.

Binnen mijn Sentry-omgeving heb ik ervoor gekozen om voor elke service en webapp een apart project aan te maken. Zo kan ik onderscheid maken tussen de verschillende componenten en efficiënter fouten identificeren en aanpakken.

Interessant genoeg lijkt de integratie van Sentry binnen een C#-applicatie sterk op die binnen een Node.js-applicatie, zoals ik in mijn blog beschreven heb.

## 5. Bijdrage code review/kwaliteit anderen en security

Competenties: *DevOps-7 - Attitude*, *DevOps-4 DevSecOps*

Tijdens het project heb ik veel Pull Requests nagekeken en feedback gegeven. Een daarvan is het nakijken van de eerste versie van Nuke build op het project, dit was een nieuwe toevoeging en een test om te kijken of de build pipeline goed werkte op master. 

Ik heb nog 2 andere Pull Requests nagekeken van de MaintenanceHistory service en de MaintenanceHistory view. De eerste was een nieuwe service die toegevoegd werd en de tweede was een view die toegevoegd werd aan de webapplicatie. De view was nog niet helemaal goed en heb ik veranderingen voorgesteld.

Ik heb ook een Pull Request nagekeken die de feedback had verwerkt van de Product Owner. Deze was goedgekeurd en kon gemerged worden.

Hieronder een overzicht van vier grote reviews die ik heb gedaan:

1. [Pullrequest goedgekeurd van Nuke build pipeline](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/32)
2. [Pullrequest goedgekeurd van wijziging feedback op webapp](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/52)
3. [Pullrequest goedgekeurd van MaintenanceHistory service](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/19)
4. [Pullrequest afgewezen van MaintenanceHistory view](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/33) (en na de wijzigingen op mijn feedback goedgekeurd)

Er is aan mij ook nog een vraag gesteld waar ik Sentry host, omdat dit in de cloud wordt gehost kan het een security concern zijn. Dit heb ik beschreven in een ADR, lees hoofdstuk 6 voor meer informatie.

## 6. Bijdrage documentatie

Competenties: *DevOps-6 Onderzoek*

Mijn bijdrage aan documentatie is vooral het opzetten van de individuele documenten, ADR's en een kleine bijdrage aan het C4 model. 

Mijn documentatie bijdrage:
- Ik heb een ADR geschreven over de opslag van Sentry, want dit is een security concern. Je kunt ervoor kiezen om Sentry te hosten via hun eigen hosting service, of om het juist zelf te doen.  
- Individuele documenten opgesteld voor mijn groepje.
- Een kleine bijdrage geleverd aan het C4 model, we hebben samen gewerkt op 1 computer en die aangesloten op de beamer en zo dus samen het C4 model opgesteld.

Hier een aantal commits van mijn bijdrage aan de documentatie:
1. [Opstellen individuele documenten](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/2be407ce9f56aa069678dbf8e8512908b9b58699)
2. [Opstellen ADR van Sentry](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/095f3a65c83b90c9c1c6fae2ee21f94ef827df62)

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Competenties: *DevOps-1 - Continuous Delivery*, *Agile*

Tijdens de scrum ceremonies hebben we onderling niet afgesproken wie welke rol ging oppakken, ik heb dan vaker de notulen geschreven dan niet. 

Na de eerste sprint planning hebben we met zijn allen gezeten om acceptatie criteria te maken voor alle user-stories.

De feedback op ons tijdens de retro was vooral dat we heel veel moesten doen in een redelijk korte tijd; Pitstop leren, sprint lengte is kort, onderzoeken toepassen, functionaliteit toepassen en documentatie schrijven.

## 8. Leerervaringen

Competenties: *DevOps-7 - Attitude*

Tops:
- Ik heb geleerd hoe je Sentry kan integreren in een C#-applicatie en hoe je dit kan toepassen in een C# solution met verschillende kleinere projecten.
- Ik ken iedereen binnen mijn groepje al van vorige projecten, dit maakt het samenwerken een stuk makkelijker en gezelliger.
- Uiteindelijk kregen een aantal van ons een error op de database, toen ben ik gaan uitzoeken wat er aan de hand was en kwam het door Docker zelf. Toen heb ik Docker gedowngrade en toen werkte het weer.

Tips:
- Als we samen als groep binnen een bestaand project gaan werken, even een ochtend of middag als groep pakken om door het project heen te lopen en door te klikken is een beter idee als dit zelf doen.
- Het is handiger als we vaker een Daily stand-up doen, want ik wist soms niet waar iemand anders mee bezig was. Dus dat ik kan voorstellen om dat te doen.

## 9. Conclusie & feedback

Competenties: *DevOps-7 - Attitude*

Dit project heeft me waardevolle inzichten gegeven. Ik heb bijvoorbeeld geleerd dat het integreren van Sentry binnen een C#-project vergelijkbaar is met hoe dit werkt in Node.js-projecten. De ervaring heeft ook aangetoond dat het toevoegen van een nieuwe service complexer kan zijn dan verwacht, vooral binnen een bestaande codebase.

Het samenwerken met een bekend team verliep prettig, omdat we wisten wat we van elkaar konden verwachten, wat de samenwerking soepel en aangenaam maakte. Een belangrijk verbeterpunt voor de toekomst is het frequenter houden van daily stand-ups, zodat we meer inzicht hebben in elkaars werkzaamheden en de voortgang beter kunnen monitoren.