# Eigen bijdrage Max

Als deliverable voor de individuele bijdrage in het beroepsproduct maak een eigen markdown bestand `<mijn-voornaam>.md` in je repo aan met tekst inclusief linkjes naar code en documentaties bestanden, pull requests, commit diffs. Maak hierin de volgende kopjes met een invulling.

Je schrapt verder deze tekst en vervangt alle andere template zaken, zodat alleen de kopjes over blijven. **NB: Aanwezigheid van template teksten na inleveren ziet de beoordelaar als een teken dat je documentatie nog niet af is, en hij/zij deze dus niet kan of hoeft te beoordelen**.

Je begin hier onder het hoofdkopje met een samenvatting van je bijdrage zoals je die hieronder uitwerkt. Best aan het einde schrijven. Zorg voor een soft landing van de beoordelaar, maar dat deze ook direct een beeld krijgt. Je hoeft geen heel verslag te schrijven. De kopjes kunnen dan wat korter met wat bullet lijst met links voor 2 tot 4 zaken en 1 of 2 inleidende zinnen erboven. Een iets uitgebreidere eind conclusie schrijf je onder het laatste kopje.


## 1. Code/platform bijdrage

Competenties: *DevOps-1 Continuous Delivery*

<!-- Beschrijf hier kort je bijdrage vanuit je rol, developer (Dev) of infrastructure specialist (Ops). Als Developer beschrijf en geef je links van minimaal 2 en maximaal 4 grootste bijdrages qua code functionaliteiten of non-functionele requirements. Idealiter werk je TDD (dus ook commit van tests en bijbehorende code tegelijk), maar je kunt ook linken naar geschreven automatische tests (unit tests, acceptance tests (BDD), integratie tests, end to end tests, performance/load tests, etc.). Als Opser geef je je minimaal 2 maximaal 4 belangrijkste bijdragen aan het opzetten van het Kubernetes platform, achterliggende netwerk infrastructuur of configuration management (MT) buiten Kubernetes (en punt 2). -->

- <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/17>

Gewerkt aan het opzetten van de basis van de nieuwe service/functionaliteit voor dit project, namelijk een dossier voor alle uitgevoerde waarzaamheden waarop we uiteindelijk functionaliteit konden maken. Dit bestond uit het maken van een opzet van de API die we gingen gebruiken. Ik heb dit werk ook verdeeld met een ander teamgenoot. Werkzaamheden die hierbij hoorde waren: Het opzetten van de database & de structuur hiervan uitwerken, werkende (automatische) migraties, een test endpoint maken & docker file maken

- <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/1>
  - Subissue: <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/26>


Nadat er een opzet was gemaakt voor de service kon hier dus nu de functionaliteit voor gemaakt worden. Met dezelfde teamgenoot ging ik verder met de userstorie [Onderhoudsgeschiedenis inzien](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/1). Dit was de de basisfunctionaliteit voor de service. Ik heb hierin de verantwoordelijkheid genomen over het uitlezen & het ophalen van de nieuwe data, waarbij het andere teamgenoot heeft gewerkt aan het opslaan van de nieuwe data. Hierbij heb ik dus de nodige get-requests geschreven in de API en heb ik een volledig nieuwe frontend opgezet voor de nieuwe service.

## 2. Bijdrage app configuratie/containers/kubernetes

Competenties: *DevOps-2 Orchestration, Containerization*

<!-- Beschrijf en geef hier links naar je minimaal 2 en maximaal 4 grootste bijdragen qua configuratie, of bijdrage qua 12factor app of container Dockerfiles en/of .yml bestanden of vergelijkbare config (rondom containerization en orchestration). -->

De Docker file opgezet voor de nieuwe service samen met een andere teamgenoot, tijdens het opzetten van de basisfunctionaliteit. Deze hadden we eerst gegenereerd doormiddel van c#.net & hadden we deze nog anagevuld/aangepast gebaseerd op alle andere dockerfiles van andere services. Dit bleek uiteindelijk niet helemaal goed te werken en moesten we uitzoeken waarom. Dit heeft helaas best wel een poos geduurd, maar na een tijd zijn we er gelukkig uit gekomen.

Commits:

- <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/bb2c7455e3652f568eb2bdd300e2c7da6a4a9d66>
- <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/f1736e0ebf486e80da22f0044d9b506c196c82e8#diff-f83ad18670b54818e524b4badec59460d3621e6ef0c93ddaeecc114650bc8fec>
- <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/ab785c7a5c830dcf18b6fddbad19e6bb195836e3>
- <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/39>

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Competenties: *DevOps-1 - Continuous Delivery*, *DevOps-3 GitOps*, *DevOps-5 - SlackOps*

<!-- Beschrijf hier en geef links naar je bijdragen aan het opzetten en verder automatiseren van delivery pipeline, GitOps toepassing en/of het opzetten van monitoring, toevoegen van metrics en custom metrics en rapportages.

NB Het gebruik van *versiebeheer* ((e.g. git)) hoort bij je standaardtaken en deze hoef je onder dit punt NIET te beschrijven, het gaat hier vooral om documenteren van processtandaarden, zoals toepassen van een pull model. -->

Zabbix toegepast en gebruikt. Zabbix ook lokaal beschikbaar gemaakt via de build pipeline door gebruik te maken van nodeports. 

Commits:

- <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/60/commits/95a3fe3bc137dfbcff0cd8f5f38cdae375774690>

## 4. Onderzoek

Competenties: *Nieuwsgierige houding*

<!-- Beschrijf hier voor het Course BP kort je onderzochte technologie met een link naar je blog post, of het toepassen ervan gelukt is en hoe, of waarom niet. Beschrijf evt. kort extra leerervaringen met andere technologieen of verdieping sinds het blog.

Tijdens het grote project beschrijf je hier onderzoek naar het domein en nieuwe onderzochte/gebruikte DevOps technologieën. Wellicht heb je nogmaals de voor blog onderzochte technologie kunnen toepassen in een andere context. Verder heb je nu een complex domein waar je in moet verdiepen en uitvragen bij de opdrachtgever. Link bijvoorbeeld naar repo's met POC's of, domein modellen of beschrijf andere onderwerpen en link naar gebruikte bronnen.

Als de tijdens course onderzochte technologie wel toepasbaar is kun je dit uiteraard onder dit punt noemen. Of wellicht was door een teamgenoot onderzochte technologie relevant, waar jij je nu verder in verdiept hebt en mee gewerkt hebt, dus hier kunt beschrijven. Tot slot kun je hier ook juist een korte uitleg geef over WAAROM  jouw eerder onderzochte technologie dan precies niet relevant of inpasbaar was. Dit is voor een naieve buitenstaander niet altijd meteen duidelijk, maar kan ook heel interessant zijn. Bijvoorbeeld dat [gebruik van Ansible in combi met Kubernetes](https://www.ansible.com/blog/how-useful-is-ansible-in-a-cloud-native-kubernetes-environment) niet handig blijkt. Ook als je geen uitgebreid onderzoek hebt gedaan of ADR hebt waar je naar kunt linken, dan kun je onder dit kopje wel alsnog kort conceptuele kennis duidelijk maken. -->

Zabbix toegepast en werkend gekregen op zowel lokaal als op de live omgeving. In tegenstelling tot de blogpost heb is dit nu niet gedaan met docker compose maar direct op kubernetes doormiddel van Helm. Dit heeft het leven ook een heel stuk makkelijker gemaakt aangezien je alleen je Helm configuratie goedm oet ehbben staan en de rest gebeurt vanzelf! Zabbix via Helm initialiseert, stelt zichzelf in en linkt de zabbix agent meteen goed op de k8s node, dit hoef je dus allemaal niet zelf te doen. er geen extra leereravingen bij opgedaan. Nogsteeds heel basis Zabbix toegepast. Geen tijd ervoor gehad om er verder op in te duiken en geavanceerdere toepassingen te maken.

Commits:

- <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/39>

Blogpost:

- <https://github.com/hanaim-devops/devops-blog-mwoaksx/blob/main/src/dev-blog-zabbix/README.md>

## 5. Bijdrage code review/kwaliteit anderen en security

Competenties: *DevOps-7 - Attitude*, *DevOps-4 DevSecOps*

<!-- Beschrijf hier en geef links naar de minimaal 2 en maximaal 4 grootste *review acties* die je gedaan hebt, bijvoorbeeld pull requests incl. opmerkingen. Het interessantst zijn natuurlijk gevallen waar code niet optimaal was. Zorg dat je minstens een aantal reviews hebt waar in gitlab voor een externe de kwestie ook duidelijk is, in plaats van dat je dit altijd mondeling binnen het team oplost. -->

Ik heb bijgedragen aan de codereviews van dit project. Hieronder een aantal linkjes naar pull requests die (onder andere) door mij zijn nagekeken:

- Onderdelen inzien userstory: <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/53>
- Migratie fixen: <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/64>
- Deel van c4 model: <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/55>

## 6. Bijdrage documentatie

Competenties: *DevOps-6 Onderzoek*

<!-- Zet hier een links naar en geef beschrijving van je C4 diagram of diagrammen, README of andere markdown bestanden, ADR's of andere documentatie. Bij andere markdown bestanden of doumentatie kun je denken aan eigen proces documentatie, zoals code standaarden, commit- of branchingconventies. Tot slot ook user stories en acceptatiecriteria (hopelijk verwerkt in gitlab issues en vertaalt naar `.feature` files) en evt. noemen en verwijzen naar handmatige test scripts/documenten. -->

Ik heb aan het c4 model & cdmm gewerkt en een adr geschreven.

Commits:

- <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/35>
- <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/73>
- <https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/40>

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Competenties: *DevOps-1 - Continuous Delivery*, *Agile*

<!-- Beschrijf hier minimaal 2 en maximaal 4 situaties van je inbreng en rol tijdens Scrum ceremonies. Beschrijf ook feedback of interventies tijdens Scrum meetings, zoals sprint planning of retrospective die je aan groespgenoten hebt gegeven.

Beschrijf tijdens het project onder dit kopje ook evt. verdere activiteiten rondom communicatie met de opdrachtgever of domein experts, of andere meer 'professional skills' of 'soft skilss' achtige zaken. -->

Niet te veel met scrum ceremonies bezig geweest, vooral voor de kanban aanpak gegaan zodat we niet zoveel overhead creeerde voor dit kleinschalig project. Wel de vooringeplande scrum ceremonies gehouden, sprintplanning & review en retrospective. Ik ben een keer de voorzitter geweest van het gesprek en zo heeft ieder lid van het projectteam ook elke meeting wat genoteerd indien nodig.

## 8. Leerervaringen

Competenties: *DevOps-7 - Attitude*

Geef tot slot hier voor jezelf minimaal 2 en maximaal **4 tops** en 2 dito (2 tot 4) **tips** á la professional skills die je kunt meenemen in je verdere loopbaan. Beschrijf ook de voor jezelf er het meest uitspringende hulp of feedback van groepsgenoten die je (tot dusver) hebt gehad tijdens het project.

## 9. Conclusie & feedback

Competenties: *DevOps-7 - Attitude*

Schrijf een conclusie van al bovenstaande punten. En beschrijf dan ook wat algemener hoe je terugkijkt op het project. Geef wat constructieve feedback, tips aan docenten/beoordelaars e.d. En beschrijf wat je aan devops kennis, vaardigheden of andere zaken meeneemt naar je afstudeeropdracht of verdere loopbaan.
