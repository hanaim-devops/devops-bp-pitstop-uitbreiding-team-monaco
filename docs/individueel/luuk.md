# Eigen bijdrage Luuk Lentjes

## Samenvatting van mijn bijdrage
Ik heb vanuit mijn DevOps-rol verschillende taken uitgevoerd in dit project, zoals het opzetten van de maintenancehistory API, het configureren van de applicatie in containers en Kubernetes, en het toepassen van Argo CD voor continue integratie en delivery. Daarnaast heb ik onderzoek gedaan naar Argo CD en heb ik een C4-model en ADR-documentatie opgesteld om mijn aanpak en keuzes te verantwoorden. Mijn bijdrage aan code reviews en scrum-ceremonies heeft de kwaliteit van het project ondersteund.

## 1. Code/platform bijdrage

Competenties: *DevOps-1 Continuous Delivery*

Als developer heb ik de MaintenanceHistory API opgezet, een nieuwe service die de onderhoudshistorie van auto’s bijhoudt. Ik heb hierbij de configuratie opgezet om history-gegevens via RabbitMQ messages op te slaan in de database. Bij deze werkzaamheden horen de volgende commits:
- [Commit 1](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/f0739226d69d42faca72ce0fd881a5813a84968d)
- [Commit 2](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/99f53eec8c3feaed7140eca977749031f836d547)

## 2. Bijdrage app configuratie/containers/kubernetes

Competenties: *DevOps-2 Orchestration, Containerization*

In dit project heb ik de Dockerfile voor de MaintenanceHistory-service opgesteld en deze werkend gemaakt in een container voor gebruik binnen Kubernetes. In de laatste commit heb ik Argo CD geconfigureerd met een nodeport om de applicatie lokaal op een andere poort te draaien.

Bij deze configuraties horen de volgende commits:
- [Commit 1](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/060c167769de080402c0ae8969bfb4e78d7b7a8c)
- [Commit 2](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/a6fbc02acfb4a3b18a317b16a6be5dfa5c38c5a3)
- [Commit 3](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/cb930cb7ace8bc049f8f5e102d3b2e0f7eb58044)

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Competenties: *DevOps-1 - Continuous Delivery*, *DevOps-3 GitOps*, *DevOps-5 - SlackOps*

In de CI/CD pipeline heb ik een stap toegevoegd om Argo CD lokaal te laten deployen op een andere poort. Dit maakt lokaal testen en ontwikkelen efficiënter.

Bij deze wijziging hoort de volgende commit:
- [Commit 1](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/f1d949712e4566a625e133758154be62679cefed)

## 4. Onderzoek

Competenties: *Nieuwsgierige houding*

Mijn onderzoek richtte zich op Argo CD, een declaratieve GitOps-tool die continue delivery binnen Kubernetes ondersteunt. Argo CD vereenvoudigt het applicatiebeheer door het gewenste eindresultaat te definiëren en dit automatisch te beheren. Meer informatie is beschikbaar in mijn blogpost: [Argo CD Blog](https://github.com/hanaim-devops/devops-blog-luuk-lentjes/blob/main/src/dev-blog-argo-cd-binnen-gitops-processen-en-kubernetes/README.md).

In dit project heb ik Argo CD ingezet om de applicatie te deployen. Details over de keuze en implementatie staan in mijn [ADR](../adr/argocd.md). Daarnaast heb ik een klein deel van Kevin's onderzoek over Nuke Build toegepast in de pipeline, waarmee Argo CD op een andere poort bereikbaar werd gemaakt. Ik ontdekte dat Argo CD automatisch images kan updaten bij nieuwe releases, maar dit heb ik wegens tijdgebrek niet toegepast.

## 5. Bijdrage code review/kwaliteit anderen en security

Competenties: *DevOps-7 - Attitude*, *DevOps-4 DevSecOps*

Gedurende dit project heb ik de volgende pull requests gereviewed:
- [PR 1](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/58)
- [PR 2](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/65)
- [PR 3](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/64)
- [PR 4](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/pull/45)

Deze reviews werden vaak gecombineerd met pair programming om direct feedback te geven en verbeteringen door te voeren.

## 6. Bijdrage documentatie

Competenties: *DevOps-6 Onderzoek*

Ik heb het C4-model opgesteld, inclusief het container- en componentdiagram, om een duidelijk overzicht te bieden van de architectuur. Deze werkzaamheden zijn gedocumenteerd in de volgende commits:
- [Commit 1](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/3ac5bba21b905381a507236558c04dba01e432ab)
- [Commit 2](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/97f08193b93eed381734c1ac9c674604ca7a5f58)

Daarnaast heb ik een ADR geschreven over Argo CD:
- [Commit 1](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-monaco/commit/97f08193b93eed381734c1ac9c674604ca7a5f58)

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Competenties: *DevOps-1 - Continuous Delivery*, *Agile*

Tijdens scrum-meetings heb ik een keer notulen gemaakt en een vergadering geleid. Toen ik voorzitter was heb ik het gesprek alleen geintroduceerd en Kevin het woord gaf, omdat ik die dag niet goed voelde. 
Het notuleren vergde scherpte en nauwkeurigheid, omdat ik het gesprek goed moest volgen en de informatie ook nog begrijpen. Daarbij ben ik ook niet z'n sneller typer, dus dat was een uitdaging.

## 8. Leerervaringen

Competenties: *DevOps-7 - Attitude*

### Tops
- Ik heb veel geleerd over Argo CD en de toepassing ervan in een project.
- Het opstellen en implementeren van een C4-model was een waardevolle leerervaring.

### Tips
- Ik had meer aandacht kunnen besteden aan code reviews, vooral op het gebied van tests.
- Ik had de dagelijkse stand-ups actiever kunnen bevorderen; deze werden niet altijd gehouden, waardoor we soms minder inzicht hadden in elkaars werk.

## 9. Conclusie & feedback

In dit project heb ik veel nieuwe technologieën gebruikt en toegepast in de applicaite. Ik heb het meeste geleerd hoe ik tools zoals Argo CD en RabbitMQ kan integreren in een .NET-project en hoe belangrijk het is om duidelijke communicatie tussen microservices op te zetten. Het werken in een team was fijn, omdat we elkaar al goed kenden en we wisten wat we van elkaar konden verwachten.

Een belangrijke les is dat het toevoegen van nieuwe tools of services soms moeilijker kan zijn dan het lijkt, vooral als je deze moet aanpassen binnen een bestaande codebase. Daarnaast heb ik gemerkt hoe handig het is om regelmatig korte updates te doen in daily stand-ups, zodat iedereen op de hoogte blijft van elkaars werk. Dit helpt om het overzicht te bewaren en problemen sneller op te lossen.

Kortom, dit project heeft mijn technische vaardigheden verbeterd en me beter laten begrijpen hoe DevOps-processen zoals Continuous Delivery, GitOps en monitoring werken in een echte omgeving.
