# CDMM

CDMM ingevuld en gebaseerd op [CDMM beoordelingsmodel](https://minordevops.nl/beoordelingsmodel-groep.html) van Minordevops.nl

## 🧑‍🤝‍🧑 Cultuur & Organisatie

Wij vinden dat we binnen deze categorie onzelf bevinden in Beginner 🥱. Dit denken wij omdat we voldoen aan een aantal punten die relevant zijn aan de categorie:

- [x] CO-101 Eén backlog per team: Er is een backlog aanwezig voor het team waarin alle issues staan van het project.
- [x] CO-102 Delen van pijn: Elk lid van het team heeft gelijk werk & werkdruk
- [ ] CO-103 Stabiel team per project
- [x] CO-104 Basis Agile methode: Er wordt gebruik gemaakt van basic scrum binnen het project
- [ ] CO-105 Testen onderdeel development

- [x] CO-205 Vast proces voor wijzigingen (DB/CM/Docs/Code/Artefacts): Er is een vast proces voor wijzigingen op belangrijke branches, bijvoorbeeld pull requests om code naar main te zetten
- [x] CO-206 Decentrale besluitvorming: Binnen in een taak hoeven beslissingen of keuzes niet centraal besproken te worden, maar is degene die momenteel bezig is met een taak er verantwoordelijk voor

## ⛪ Ontwerp & Architectuur

Wij vinden dat we binnen deze categorie onzelf bevinden in Gemiddeld 😐. Dit denken wij omdat we voldoen aan een aantal punten die relevant zijn aan de categorie:

- [x] OA-201 Geen of minimale branching: We maken gebruik van feature branches om code te ontwikkelen.
- [ ] OA-202 Branch by abstraction
- [ ] OA-203 Configuratie als Code (CaC): 
- [ ] OA-204 Feature hiding (feature toggle e.d.)
- [ ] OA-205 Modules omzetten naar componenten

## 🏗️ Build & Deploy

Wij vinden dat we binnen deze categorie onzelf bevinden in Gemiddeld 😐. Dit denken wij omdat we voldoen aan een aantal punten die relevant zijn aan de categorie:

- [x] BD-201 Auto triggered builds (commit hooks): Er word gebruik gemaakt van Nuke voor automatische getriggerde build & deploys via GitHub Actions
- [x] BD-202 Geautomatiseerde tags & versies: Tags en versies worden automatisch geannoteerd met 2 versie strategieen GitVersion of CalanderVersion
- [x] BD-203 Build once deploy anywhere: Word gebruik gemaakt van docker images om dit werkend te krijgen
- [ ] BD-204 Automatiseer meeste DB wijzigingen
- [ ] BD-205 Basis pipeline, prod deploy
- [ ] BD-206 Gescripte config wijzigingen
- [ ] BD-207 Standaard proces voor alle omgevingen: 

## 🧪 Test & Verificatie

Wij vinden dat we binnen deze categorie onzelf bevinden in Gemiddeld 😐. Dit denken wij omdat we voldoen aan een aantal punten die relevant zijn aan de categorie:

- [x] TV-201 Automatische component test (geisoleerd): We maken gebruik van unit tests om de functionaliteit van onze code te verifiëren.
- [x] TV-202 Enkele automatische acceptatie tests: Van unit tests om de functionaliteit van onze code te verifiëren.

## 📈 Informatie & Rapporteren

Wij vinden dat we binnen deze categorie onzelf bevinden in Gemiddeld 😐. Dit denken wij omdat we voldoen aan een aantal punten die relevant zijn aan de categorie:

- [ ] IR-201 Gedeeld informatiemodel:
- [ ] IR-202 Traceerbaarheid ingebouwd in pipeline: Historie van de uitgevoerde pipelines kan ingezien worden. Hierdoor is er altijd een traceerbaarheid van elke pipeline
- [x] IR-203 Rapportage historie is beschikbaar: Monitoringtool Sentry gebruikt om de history en error tracking van de applicatie bij te houden