# Implementatie van Zabbix voor Monitoring

**Status**: Besloten  
**Datum**: 01-11-2024  
**Auteur**: Max van Oostwaard

## Context

In ons project hebben we behoefte aan een robuuste oplossing voor monitoring die ons in staat stelt om prestaties, netwerkstatus en applicatie-gezondheid te bewaken. Het doel is om zowel infrastructuur als applicaties continu te monitoren om vroegtijdige waarschuwingen te ontvangen en proactief te kunnen handelen bij eventuele problemen. Zabbix is overwogen vanwege zijn uitgebreide mogelijkheden voor monitoring en visualisatie, de mogelijkheid tot integratie met verschillende DevOps-tools, en de community-ondersteuning.

Zabbix biedt krachtige functies voor het monitoren van services en het genereren van meldingen op basis van door ons gedefinieerde drempelwaarden. Daarnaast sluit het aan bij ons DevOps-framework en kan het met verschillende omgevingen werken, wat belangrijk is voor de schaalbaarheid en toekomstbestendigheid van het project.

## Beslissing

We hebben besloten om Zabbix te integreren als monitoringtool in ons project vanwege zijn veelzijdige functionaliteit en de mogelijkheid tot integratie met andere monitoring- en DevOps-tools. De integratie zal plaatsvinden via de Zabbix Docker-containers, ondersteund door Kubernetes en beheerd via een community-Helmchart. De keuze voor Zabbix biedt een schaalbare oplossing voor het monitoren van het systeem, en de NodePort-configuratie stelt ons in staat om de Zabbix webinterface lokaal ook op een specifieke poort te kunnen bereiken, wat de toegankelijkheid verhoogt.

## Alternatieven

- **Prometheus en Grafana**: Prometheus is een krachtige open-source tool voor metrics, en in combinatie met Grafana kan het worden gebruikt voor visuele monitoring. Deze tools bieden echter minder uitgebreide mogelijkheden voor event monitoring en geautomatiseerde waarschuwingsmeldingen dan Zabbix.

- **Datadog**: Hoewel Datadog een cloud-gebaseerde oplossing biedt met eenvoudige installatie en configuratie, brengt het gebruik ervan extra kosten met zich mee. Het kan een optie zijn voor toekomstig gebruik wanneer we meer opslag- en analysemogelijkheden nodig hebben.

- **Nagios**: Een betrouwbare tool voor server- en netwerkmonitoring, maar het biedt minder integratiemogelijkheden met moderne DevOps-tools en heeft beperkingen op het gebied van visualisatie en automatische notificaties.

## Consequenties

### Voordelen

Gespecialiseerde monitoring en melding: Zabbix biedt uitgebreide mogelijkheden voor event monitoring en alarmen die ons in staat stellen om problemen snel te detecteren en hierop te reageren.
Flexibele integratie met DevOps-tools: Zabbix ondersteunt integratie met Kubernetes en de mogelijkheid om te werken met Helmcharts, wat bijdraagt aan een eenvoudig beheer binnen onze container-gebaseerde infrastructuur.
Efficiënte visualisatie van gegevens: Met Zabbix kunnen we eenvoudig dashboards configureren om inzicht te krijgen in kritieke prestaties en het gebruik van resources.

### Nadelen

Complexiteit van configuratie: De configuratie en het instellen van Zabbix kunnen complex zijn en vereisen specifieke kennis, wat een leercurve betekent voor het team.
Afhankelijkheid van Kubernetes-toegang: De huidige configuratie maakt gebruik van NodePort, wat vereist dat de toegang tot Kubernetes correct is ingesteld en onderhouden, wat soms kan leiden tot beheeruitdagingen.

## Bronnen

- [Zabbix Officiële Documentatie](https://www.zabbix.com/documentation/current/en/manual)
- [Zabbix Community Helm Chart](https://github.com/zabbix-community/helm-zabbix)
- [Prometheus](https://prometheus.io/)
- [Datadog](https://www.datadoghq.com/)
- [Grafana](https://grafana.com/)
