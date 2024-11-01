# Eigen bijdrage Max

<!-- Als deliverable voor de individuele bijdrage in het beroepsproduct maak een eigen markdown bestand `<mijn-voornaam>.md` in je repo aan met tekst inclusief linkjes naar code en documentaties bestanden, pull requests, commit diffs. Maak hierin de volgende kopjes met een invulling.

Je schrapt verder deze tekst en vervangt alle andere template zaken, zodat alleen de kopjes over blijven. **NB: Aanwezigheid van template teksten na inleveren ziet de beoordelaar als een teken dat je documentatie nog niet af is, en hij/zij deze dus niet kan of hoeft te beoordelen**.

Je begin hier onder het hoofdkopje met een samenvatting van je bijdrage zoals je die hieronder uitwerkt. Best aan het einde schrijven. Zorg voor een soft landing van de beoordelaar, maar dat deze ook direct een beeld krijgt. Je hoeft geen heel verslag te schrijven. De kopjes kunnen dan wat korter met wat bullet lijst met links voor 2 tot 4 zaken en 1 of 2 inleidende zinnen erboven. Een iets uitgebreidere eind conclusie schrijf je onder het laatste kopje. -->

Tijdens het project heb ik vooral gewerkt aan de opzet en functionaliteit van de nieuwe service binnen de applicatie. Ik was verantwoordelijk voor het ontwikkelen van een dossier voor uitgevoerde werkzaamheden, waarbij ik samen met een teamgenoot de basisfuncties en database structuur van de nieuwe service heb opgezet. Daarna heb ik me gericht op het ophalen en presenteren van data via een nieuwe frontend, terwijl mijn teamgenoot zich op het opslaan van data richtte. Naast deze development-bijdragen heb ik gewerkt aan de Zabbix monitoring implementatie met Helm, waarbij ik Zabbix lokaal en in de live-omgeving beschikbaar maakte. Verder heb ik ook actief meegewerkt aan codereview, de opzet van het C4-model en documentatie zoals de ADR’s en CDMM. Door mijn ervaring in dit project heb ik mijn DevOps-kennis en -vaardigheden verder versterkt en veel geleerd over hoe een algemeen DevOps-ecosysteem er uit ziet.

## 1. Code/platform bijdrage

Competenties: *DevOps-1 Continuous Delivery*

<!-- Beschrijf hier kort je bijdrage vanuit je rol, developer (Dev) of infrastructure specialist (Ops). Als Developer beschrijf en geef je links van minimaal 2 en maximaal 4 grootste bijdrages qua code functionaliteiten of non-functionele requirements. Idealiter werk je TDD (dus ook commit van tests en bijbehorende code tegelijk), maar je kunt ook linken naar geschreven automatische tests (unit tests, acceptance tests (BDD), integratie tests, end to end tests, performance/load tests, etc.). Als Opser geef je je minimaal 2 maximaal 4 belangrijkste bijdragen aan het opzetten van het Kubernetes platform, achterliggende netwerk infrastructuur of configuration management (MT) buiten Kubernetes (en punt 2). -->

Gewerkt aan het opzetten van de basis van de nieuwe service/functionaliteit voor dit project, namelijk een dossier voor alle uitgevoerde waarzaamheden waarop we uiteindelijk functionaliteit konden maken. Dit bestond uit het maken van een opzet van de API die we gingen gebruiken. Ik heb dit werk ook verdeeld met een ander teamgenoot. Werkzaamheden die hierbij hoorde waren: Het opzetten van de database & de structuur hiervan uitwerken, werkende (automatische) migraties, een test endpoint maken & docker file maken

- [Issue commit history van opzetten service](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/17)

Nadat er een opzet was gemaakt voor de service kon hier dus nu de functionaliteit voor gemaakt worden. Met dezelfde teamgenoot ging ik verder met de userstorie [Onderhoudsgeschiedenis inzien](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/1). Dit was de de basisfunctionaliteit voor de service. Ik heb hierin de verantwoordelijkheid genomen over het uitlezen & het ophalen van de nieuwe data, waarbij het andere teamgenoot heeft gewerkt aan het opslaan van de nieuwe data. Hierbij heb ik dus de nodige get-requests geschreven in de API en heb ik een volledig nieuwe frontend opgezet voor de nieuwe service.

- [Issue comit history van bovenstaande userstory](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/1)
- [Frontend subissue commit history van bovenstaande userstory](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/26)

## 2. Bijdrage app configuratie/containers/kubernetes

Competenties: *DevOps-2 Orchestration, Containerization*

<!-- Beschrijf en geef hier links naar je minimaal 2 en maximaal 4 grootste bijdragen qua configuratie, of bijdrage qua 12factor app of container Dockerfiles en/of .yml bestanden of vergelijkbare config (rondom containerization en orchestration). -->

De Docker file opgezet voor de nieuwe service samen met een andere teamgenoot, tijdens het opzetten van de basisfunctionaliteit. Deze hadden we eerst gegenereerd doormiddel van c#.net & hadden we deze nog anagevuld/aangepast gebaseerd op alle andere dockerfiles van andere services. Dit bleek uiteindelijk niet helemaal goed te werken en moesten we uitzoeken waarom. Dit heeft helaas best wel een poos geduurd, maar na een tijd zijn we er gelukkig uit gekomen.

Docker file commits:

- [Commit 1](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/bb2c7455e3652f568eb2bdd300e2c7da6a4a9d66)
- [Commit 2](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/f1736e0ebf486e80da22f0044d9b506c196c82e8#diff-f83ad18670b54818e524b4badec59460d3621e6ef0c93ddaeecc114650bc8fec)
- [Commit 3](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/ab785c7a5c830dcf18b6fddbad19e6bb195836e3)

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Competenties: *DevOps-1 - Continuous Delivery*, *DevOps-3 GitOps*, *DevOps-5 - SlackOps*

<!-- Beschrijf hier en geef links naar je bijdragen aan het opzetten en verder automatiseren van delivery pipeline, GitOps toepassing en/of het opzetten van monitoring, toevoegen van metrics en custom metrics en rapportages.

NB Het gebruik van *versiebeheer* ((e.g. git)) hoort bij je standaardtaken en deze hoef je onder dit punt NIET te beschrijven, het gaat hier vooral om documenteren van processtandaarden, zoals toepassen van een pull model. -->

Zabbix op de live omgeving laten draaien door deze te laten instaleren op k8s via Helm. Zabbix ook lokaal beschikbaar gemaakt via de build pipeline door gebruik te maken van nodeports.

Commits:

- [Commit 1](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/60/commits/95a3fe3bc137dfbcff0cd8f5f38cdae375774690)

## 4. Onderzoek

Competenties: *Nieuwsgierige houding*

<!-- Beschrijf hier voor het Course BP kort je onderzochte technologie met een link naar je blog post, of het toepassen ervan gelukt is en hoe, of waarom niet. Beschrijf evt. kort extra leerervaringen met andere technologieen of verdieping sinds het blog.

Tijdens het grote project beschrijf je hier onderzoek naar het domein en nieuwe onderzochte/gebruikte DevOps technologieën. Wellicht heb je nogmaals de voor blog onderzochte technologie kunnen toepassen in een andere context. Verder heb je nu een complex domein waar je in moet verdiepen en uitvragen bij de opdrachtgever. Link bijvoorbeeld naar repo's met POC's of, domein modellen of beschrijf andere onderwerpen en link naar gebruikte bronnen.

Als de tijdens course onderzochte technologie wel toepasbaar is kun je dit uiteraard onder dit punt noemen. Of wellicht was door een teamgenoot onderzochte technologie relevant, waar jij je nu verder in verdiept hebt en mee gewerkt hebt, dus hier kunt beschrijven. Tot slot kun je hier ook juist een korte uitleg geef over WAAROM  jouw eerder onderzochte technologie dan precies niet relevant of inpasbaar was. Dit is voor een naieve buitenstaander niet altijd meteen duidelijk, maar kan ook heel interessant zijn. Bijvoorbeeld dat [gebruik van Ansible in combi met Kubernetes](https://www.ansible.com/blog/how-useful-is-ansible-in-a-cloud-native-kubernetes-environment) niet handig blijkt. Ook als je geen uitgebreid onderzoek hebt gedaan of ADR hebt waar je naar kunt linken, dan kun je onder dit kopje wel alsnog kort conceptuele kennis duidelijk maken. -->

Mijn onderzoek voor het vak DevOps was gericht op de monitoringstool Zabbix. Zabbix is een open-source monitoringstool die het mogelijk maakt om de prestaties en beschikbaarheid van IT-systemen, netwerken, en applicaties continu te bewaken. Het biedt gedetailleerde rapportages, waarschuwingen, en dashboards, waarmee beheerders problemen vroegtijdig kunnen opsporen en oplossen.

Blogpost:

- <https://github.com/hanaim-devops/devops-blog-mwoaksx/blob/main/src/dev-blog-zabbix/README.md>

Zabbix is toegepast en werkend op zowel lokaal als op de live omgeving. In tegenstelling tot de blogpost heb is dit nu niet gedaan met docker compose maar direct op kubernetes doormiddel van Helm. Dit heeft het leven ook een heel stuk makkelijker gemaakt, aangezien ik alleen de Helm configuratie goed moest zetten, en de rest gebeurde vanzelf! Zabbix via Helm initialiseert, stelt zichzelf in en linkt de zabbix agent meteen goed op de k8s node, dit hoef je dus allemaal niet zelf te doen.
Er geen extra leereravingen bij opgedaan. Nogsteeds heel basis Zabbix toegepast. Geen tijd ervoor gehad om er verder op in te duiken en geavanceerdere toepassingen te maken.

Commits:

- [Commit 1](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/39)

## 5. Bijdrage code review/kwaliteit anderen en security

Competenties: *DevOps-7 - Attitude*, *DevOps-4 DevSecOps*

<!-- Beschrijf hier en geef links naar de minimaal 2 en maximaal 4 grootste *review acties* die je gedaan hebt, bijvoorbeeld pull requests incl. opmerkingen. Het interessantst zijn natuurlijk gevallen waar code niet optimaal was. Zorg dat je minstens een aantal reviews hebt waar in gitlab voor een externe de kwestie ook duidelijk is, in plaats van dat je dit altijd mondeling binnen het team oplost. -->

Ik heb bijgedragen aan de codereviews van dit project. Hieronder een lijst met links naar pull requests die (onder andere) door mij zijn nagekeken:

- [Onderdelen inzien userstory](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/53)
- [Fixen van de migratie](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/64)
- [Afronding C4 model](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/55)

## 6. Bijdrage documentatie

Competenties: *DevOps-6 Onderzoek*

<!-- Zet hier een links naar en geef beschrijving van je C4 diagram of diagrammen, README of andere markdown bestanden, ADR's of andere documentatie. Bij andere markdown bestanden of doumentatie kun je denken aan eigen proces documentatie, zoals code standaarden, commit- of branchingconventies. Tot slot ook user stories en acceptatiecriteria (hopelijk verwerkt in gitlab issues en vertaalt naar `.feature` files) en evt. noemen en verwijzen naar handmatige test scripts/documenten. -->

Ik heb het C4 model opgestelt en een groot deel hiervan alleen & ook een deel gezamelijk gemaakt met andere teamgenoten.

Commits:

- [C4 model issue](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/40)

Ook heb ik een ADR geschreven voor het toepassen van Zabbix:

- [Zabbix ADR issue](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/73)

Als laatste heb ik meegeholpen aan het invullen van het CDMM:

- [CDMM issue](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/issues/35)

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Competenties: *DevOps-1 - Continuous Delivery*, *Agile*

<!-- Beschrijf hier minimaal 2 en maximaal 4 situaties van je inbreng en rol tijdens Scrum ceremonies. Beschrijf ook feedback of interventies tijdens Scrum meetings, zoals sprint planning of retrospective die je aan groespgenoten hebt gegeven.

Beschrijf tijdens het project onder dit kopje ook evt. verdere activiteiten rondom communicatie met de opdrachtgever of domein experts, of andere meer 'professional skills' of 'soft skilss' achtige zaken. -->

Niet te veel met scrum ceremonies bezig geweest, vooral voor de KanBan aanpak gegaan zodat we niet zoveel overhead creeerde voor dit kleinschalig project. Wel de vooringeplande scrum ceremonies gehouden, namelijk de planning- en review van een sprint & de sprintretrospective. Ik ben een keer 'officieel' de voorzitter geweest van een ceremonie.

## 8. Leerervaringen

Competenties: *DevOps-7 - Attitude*

<!-- Geef tot slot hier voor jezelf minimaal 2 en maximaal **4 tops** en 2 dito (2 tot 4) **tips** á la professional skills die je kunt meenemen in je verdere loopbaan. Beschrijf ook de voor jezelf er het meest uitspringende hulp of feedback van groepsgenoten die je (tot dusver) hebt gehad tijdens het project. -->

### Top

- In dit project ging de samenwerking tussen de teamleden (naar mijn mening) fantastisch. Het hielp ook erg mee dat we elkaar al allemaal goed kennen.

- Hoewel ik er in het begin aardig wat moeite mee had, verbaasde ik mijzelf eigenlijk wel over hoe snel ik de weg uiteindelijk heb kunnen vinden in een vreemde applicatie zoals Pitstop

### Tip

- Van te voren het project wat beter nalopen zodat we wat een beter idee krijgen in wat voor project we terecht zijn gekomen.

- Er is soms nog het een en ander voorbij me gegaan tijdens het reviewen van PR's. Hele onnodige fouten die ik door beter testen gemakkelijk had kunnen vinden, maar die door mijn onnauwkeurigheid/gehaastheid er toch nog doorheen komen.


## 9. Conclusie & feedback

Competenties: *DevOps-7 - Attitude*

<!-- Schrijf een conclusie van al bovenstaande punten. En beschrijf dan ook wat algemener hoe je terugkijkt op het project. Geef wat constructieve feedback, tips aan docenten/beoordelaars e.d. En beschrijf wat je aan devops kennis, vaardigheden of andere zaken meeneemt naar je afstudeeropdracht of verdere loopbaan. -->

In het algemeen kijk ik positief terug op dit project. Het samenwerken met mijn team verliep goed, en de kwaliteit van onze samenwerking maakte de het werk efficiënter en effectiefer. Door de structuur van ons werk en de takenverdeling kon ik me snel en beter verdiepen in de al gebruikte technologieën en processen in Pitstop. Ook heb ik verder kunnen werken aan het het opzetten van monitoring en configuratiemanagement en het ontwikkelen van een nieuwe service met bijbehorende API en frontend. Hierdoor heb ik mijn DevOps-kennis sterk uitgebreid, met name in het toepassen van monitoring via Zabbix & in het duiken van vreemde code. Zo ben ik ervan overtuigd dat ik deze kennis goed kan inzetten in toekomstige DevOps-projecten.

Een belangrijk leerpunt voor mij is om gestructureerd en nauwkeurig PR's te beoordelen om onnodige fouten eruit te halen. Het bijhouden van een strakke codekwaliteit is erg belangrijk, en ik heb gezien hoe ik dit proces nog kan verbeteren door meer focus en nauwkeurigheid. Tot slot denk ik dat een betere voorbereiding van het project waardevol kan zijn, om hierdoor beter en sneller inzicht te krijgen in de opzet en specifieke kenmerken van een bestaande applicatie.