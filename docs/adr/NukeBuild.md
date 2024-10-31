# Integratie van Nuke Build en GitHub Actions voor CI/CD in Pitstop

**Status**: Aangenomen  
**Datum**: 15-10-2024  
**Auteur**: Kevin Slingerland

## Context

Binnen het Pitstop-project is er behoefte aan een gestroomlijnde en efficiënte CI/CD-pipeline om de build- en releaseprocessen te automatiseren. Aangezien het project een microservices-architectuur heeft en regelmatig updates en nieuwe releases vereist, moet het CI/CD-systeem eenvoudig te beheren en uitbreidbaar zijn. Nuke Build en GitHub Actions zijn overwogen als een combinatie om aan deze behoeften te voldoen.

Nuke Build biedt een code-first aanpak voor het maken van build scripts, wat aansluit bij de kennis van het ontwikkelteam dat al werkt met C#. GitHub Actions, een CI/CD-tool die geïntegreerd is met GitHub, biedt eenvoudige implementatie en beheer van workflows binnen de codebase.

## Beslissing

We hebben besloten om **Nuke Build te integreren voor het opstellen en beheren van build scripts**, samen met **GitHub Actions** voor het automatiseren van de CI/CD-workflows. Deze keuze ondersteunt de behoefte aan schaalbaarheid, flexibiliteit en eenvoud in het beheer van de pipeline.

### Alternatieven

- **MSBuild en Make**: Traditionele tools die breed ondersteund worden, maar missen de moderne code-first aanpak en flexibiliteit die Nuke Build biedt.
- **GitLab CI/CD**: GitLab biedt een krachtige CI/CD-oplossing die geïntegreerd is met GitLab repositories, GitLab kan een goede keuze zijn voor organisaties die een alles-in-één DevOps-platform zoeken. Het nadeel is dat er een aparte setup en mogelijke migratie van de huidige repositories naar GitLab nodig zou zijn, wat extra overhead en complexiteit kan introduceren.

### Consequenties

**Voordelen**:
- **Snelle integratie en onderhoud**: De combinatie van Nuke Build en GitHub Actions zorgt voor eenvoudig beheer van de CI/CD-pipeline.
- **Code-gebaseerd beheer**: Nuke Build maakt het mogelijk om build scripts te schrijven in C#, wat zorgt voor betere leesbaarheid en onderhoudbaarheid.
- **Sterke integratie met GitHub**: GitHub Actions maakt het mogelijk om workflows rechtstreeks in de repository te definiëren en te beheren.

**Nadelen**:
- **Leercurve**: Teamleden moeten vertrouwd raken met Nuke Build, wat een initiële trainingsperiode vereist.
- **Externe afhankelijkheid**: GitHub Actions is afhankelijk van GitHub’s uptime en servicegaranties, wat een risico kan zijn voor teams met specifieke compliance-eisen.

## Bronnen

- [Nuke Build](https://nuke.build/)
- [GitHub Actions](https://docs.github.com/en/actions)
- [GitLab CI/CD](https://docs.gitlab.com/ee/ci/)
