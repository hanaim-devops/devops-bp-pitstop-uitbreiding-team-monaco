# Eigen bijdrage Kevin Slingerland

In dit project heb ik mij vooral gericht op het verbeteren en automatiseren van de DevOps-processen, met nadruk op CI/CD, containerisatie en infrastructuurbeheer. Door het toepassen van Nuke Build en het opzetten van Kubernetes-manifests heb ik bijgedragen aan een schaalbare en efficiënte workflow voor de applicatie-ontwikkeling en deployment. Mijn inzicht in nieuwe technologieën en mijn proactieve houding hebben de samenwerking binnen het team bevorderd en de algehele kwaliteit van het project verhoogd.

## 1. Code/platform bijdrage

Competenties: *DevOps-1 Continuous Delivery*

Binnen dit beroepsproduct ben ik vooral werkzaam geweest als *Infrastructuur Specialist (Ops)*, Ik heb mij bezig gehouden met het opzetten van de build & deployment stappen en hier tevens ook mijn onderzoek naar Nuke Build toegepast.

[PR: Opzetten Nuke Build & Deploy](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/32/files)

[PR: Opzetten Basis Deployment Kubernetes Manifests](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/43/files)

Verder heb ik meegekeken met mijn team in het uitwerken en opzetten van de architectuur weiziging en de nieuwe microservice. Verder ben ik bezig geweest met het opsplitsen en refactoren van verschillende onderdelen in de applicatie.

[PR: Refactor to stand-alone microservice](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/70/files)

## 2. Bijdrage app configuratie/containers/kubernetes

Competenties: *DevOps-2 Orchestration, Containerization*

Ik heb voor de nieuwe microservice een Kubernetes resource gedefineerd, ook is de build zo opgezet dat container applicaties automatisch kunnen worden gebouwd als dit is ingesteld met een tag `<IsContainerApp>true</IsContainerApp>` in de .csproj.

[PR: Add Kubernetes Resource & Mark App as ContainerApp](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/63/files)

Om onze build zo soepel mogelijk te laten verlopen worden onze images gebuild en gepublished in de pipeline, dit gebeurd automatisch wanneer de build `IPublishContainerImages` implementeerd. Hierin worden ook alle images getagged en de base images gebuild.

[PR: Setup IPublishContainerImages](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/32/files#diff-7711300ea4e21be65578aac1e8b1ca73a13d608dff9e6568fda85ae6f66a338b)

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Competenties: *DevOps-1 - Continuous Delivery*, *DevOps-3 GitOps*, *DevOps-5 - SlackOps*

Binnen ons product is er gebruik gemaakt van een pull model en short lived branches, dit heb ik opgezet door een aantal branch protection rules toe te passen binnen onze GitHub repo, hierdoor heb ik ook afgedwongen dat er een liniaire Git history is ontstaan met behulp van reabasen. Dit zorgt er voor dat ieder issue in principe 1 commit op de master branch word waardoor er goed terug te zien is wat er per issue is aangepast.

Binnen onze pipeline worden ook een aantal monitoring applicaties uitgerold zoals Zabbix en ArgoCD, hiervoor word er gebruik gemaakt van helm charts en deze configuratie word ook automatisch uitgerold.

[PR: Setup Deployment for Helm Charts & Config](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/58/files)

## 4. Onderzoek

Competenties: *Nieuwsgierige houding*

Binnen het beroeps product heb ik mijn technologie Nuke Build toegepast, zoals al eerder gelezen is dit op een breed scala aan taken ingezet waaronder het uitrollen van applicaties, kubernetes manifesten, statische code analyse of het uitvoeren van testen.

[DeOps Blog: Supercharge your workflow with Nuke Build](https://github.com/hanaim-devops/devops-blog-KSlingerland/tree/main/src/nuke-build-supercharge-your-workflow)

Binnen dit beroepsproduct was het doel om de bestaande manier van builden en deployen te vervangen door Nuke Targets gedefineerd in C# code. Het ging hier vooral om de script om de docker images te builden en het applyen van kubernetes manifesten.

Ook kwamen we er achter dat het uitrollen van verschillende applicaties zoals argo-cd en zabbix goed te doen was via een pipeline en hierdoor deze configuratie ook een stuk beter te beheren was.

Het grootste leer punt zal bij Nuke zijn om niet door te slaan in de opzet, de verschillende onderdelen zijn nu opgeknipt in herbruikbare losstaande onderdelen hier heb ik redelijk wat tijd aan besteed maar dit was achteraf gezien mischien helemaal nier nodig aangezien het hier om 1 pipeline ging voor 1 project dat 2 weken heeft geduurd. Wel zou ik nu deze onderdelen los kunnen trekken naar een eigen repository.

[GitHub Repo: Build Compoenents](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/tree/master/build)

_Verbetering voor volgens project_

Alle functionaliteit is nu binnen deze repository gemaakt, voor een volgens project zou ik deze code graag in een losse repository hebben staan en dat deze components dan gepublished als package te gerbuiken zijn in verschillende projecten.


## 5. Bijdrage code review/kwaliteit anderen en security

Competenties: *DevOps-7 - Attitude*, *DevOps-4 DevSecOps*

Binnen dit beroepsproduct heb ik helaas geen review achter gelaten op een PR, wel is er tijdens de ontwikkeling doorgaans overleg geweest over hoe bepaalde zalen zoals het opzetten van de architectuur weiziging zou kunnen worden uitgevoerd en hier heb ik dan ook inspraak in gehad en mijn feeback op gegeven.

## 6. Bijdrage documentatie

Competenties: *DevOps-6 Onderzoek*

[ADR: Nuke Build & GitHub Actions](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/68/files)

[Aanvullingen CDMM](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/75/files)

Ik heb kwa documentatie een ADR geschreven voor het gebruik van Nuke Build in combinatie met GitHub Actions en verder gedurende het ontwikkelen gezorgd dat het CDMM werd aangevuld met de benodigde informatie. Verder hebben we gazamelijk gekeken naar het C4 Model.


## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Competenties: *DevOps-1 - Continuous Delivery*, *Agile*

Binnen het broepsproduct hebben wij meer Kanban gewerkt dan scrum, gezien de korte doorlooptijd en de hoeveelheid wisselend werk en onvoorspelbaarheid was het logischer om per momnent te kijken welke taken konden worden opgepakt en uitgevroerd dan dit vooraf vast te stellen met een sprint planning.

Ik ben eenmaal notulist geweest tijdens de retrospective maar hier ook redelijke inbreng gehad in de onderwerpen die aangekaart zijn zoals de invulling van het CDMM en de hoeveelheid werk en de onvoorspelbaarheid van de eerste peoject week

Andere keren heb ik of invulling gegeven aan de meeting door een controlerende en oplettende houding aan te nemen, zoals het corrigeren wanneer en mis verstanden ontstaan of het verduidelijken van vragen binnen de meetings.

## 8. Leerervaringen

Competenties: *DevOps-7 - Attitude*

Een van de punten waar ik aan moet werken is het maken van keinere PR's en het opspliten van functionaliteit in kleine brokjes

Verbeter de documentatie en communicatie rondom PR's om teamleden te helpen het werk makkelijker te volgen en te beoordelen.

Een punt dat ik meeneem is dat ik erg snel thuis kan zijn in een nieuwe code base en altijd wel mogelijkheden voor verbetering zie

Mijn inzet om nieuwe tools zoals Nuke Build te leren en effectief toe te passen, heeft gezorgd voor verbeterde automatisering en procesoptimalisatie.

## 9. Conclusie & feedback

Competenties: *DevOps-7 - Attitude*

Het project heeft mijn DevOps-vaardigheden versterkt, met een focus op infrastructuur, CI/CD, en het toepassen van Nuke Build voor geautomatiseerde workflows. Ik kijk positief terug op het project vanwege de kansen om nieuwe technologieën te leren en effectief samen te werken binnen een team. Een belangrijk inzicht was het belang van kleinere PR's en meer gestroomlijnde reviews. Ik neem deze kennis en ervaring mee naar mijn afstudeeropdracht en toekomstige rollen, met een sterke basis in automatisering en procesoptimalisatie.