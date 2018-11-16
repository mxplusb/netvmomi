# netvmomi

.NET Standard 2.0 SDK for the VMware vSphere 6 REST API.

This SDK was originally generated by [Swagger](https://github.com/swagger-api/swagger-codegen) and then modified to be human friendly. It's an active work in progress.

<a name="installation"></a>
## Installation

```ps
dotnet add package netvmomi
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using netvmomi.API;
using netvmomi.Client;
using netvmomi.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: auth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccessApi();
            var contentType = contentType_example;  // string | 

            try
            {
                // ConsoleCLI
                apiInstance.ApplianceAccessConsolecliGet(contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessApi.ApplianceAccessConsolecliGet: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://example.com/rest*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccessApi* | [**ApplianceAccessConsolecliGet**](docs/AccessApi.md#applianceaccessconsolecliget) | **GET** /appliance/access/consolecli | ConsoleCLI
*AccessApi* | [**ApplianceAccessConsolecliPut**](docs/AccessApi.md#applianceaccessconsolecliput) | **PUT** /appliance/access/consolecli | ConsoleCLI-disable
*AccessApi* | [**ApplianceAccessDcuiGet**](docs/AccessApi.md#applianceaccessdcuiget) | **GET** /appliance/access/dcui | DCUI
*AccessApi* | [**ApplianceAccessDcuiPut**](docs/AccessApi.md#applianceaccessdcuiput) | **PUT** /appliance/access/dcui | DCUI-disable
*AccessApi* | [**ApplianceAccessShellGet**](docs/AccessApi.md#applianceaccessshellget) | **GET** /appliance/access/shell | Shell
*AccessApi* | [**ApplianceAccessShellPut**](docs/AccessApi.md#applianceaccessshellput) | **PUT** /appliance/access/shell | Shell-disable
*AccessApi* | [**ApplianceAccessSshGet**](docs/AccessApi.md#applianceaccesssshget) | **GET** /appliance/access/ssh | SSH
*AccessApi* | [**ApplianceAccessSshPut**](docs/AccessApi.md#applianceaccesssshput) | **PUT** /appliance/access/ssh | SSH-disable
*AuthenticationApi* | [**ComVmwareCisSessionDelete**](docs/AuthenticationApi.md#comvmwarecissessiondelete) | **DELETE** /com/vmware/cis/session | Logout
*AuthenticationApi* | [**ComVmwareCisSessionPost**](docs/AuthenticationApi.md#comvmwarecissessionpost) | **POST** /com/vmware/cis/session | Login
*HealthApi* | [**ApplianceHealthApplmgmtGet**](docs/HealthApi.md#appliancehealthapplmgmtget) | **GET** /appliance/health/applmgmt | Applianceservices
*HealthApi* | [**ApplianceHealthDatabaseStorageGet**](docs/HealthApi.md#appliancehealthdatabasestorageget) | **GET** /appliance/health/database-storage | Databasestorage
*HealthApi* | [**ApplianceHealthLoadGet**](docs/HealthApi.md#appliancehealthloadget) | **GET** /appliance/health/load | Load
*HealthApi* | [**ApplianceHealthMemGet**](docs/HealthApi.md#appliancehealthmemget) | **GET** /appliance/health/mem | Memory
*HealthApi* | [**ApplianceHealthSoftwarePackagesGet**](docs/HealthApi.md#appliancehealthsoftwarepackagesget) | **GET** /appliance/health/software-packages | Softwarepackagesupdates
*HealthApi* | [**ApplianceHealthStorageGet**](docs/HealthApi.md#appliancehealthstorageget) | **GET** /appliance/health/storage | Storage
*HealthApi* | [**ApplianceHealthSwapGet**](docs/HealthApi.md#appliancehealthswapget) | **GET** /appliance/health/swap | Swap
*HealthApi* | [**ApplianceHealthSystemGet**](docs/HealthApi.md#appliancehealthsystemget) | **GET** /appliance/health/system | System
*HealthApi* | [**ApplianceHealthSystemLastcheckGet**](docs/HealthApi.md#appliancehealthsystemlastcheckget) | **GET** /appliance/health/system/lastcheck | Systemlastcheck
*MonitoringApi* | [**ApplianceMonitoringGet**](docs/MonitoringApi.md#appliancemonitoringget) | **GET** /appliance/monitoring | List
*MonitoringApi* | [**ApplianceMonitoringNetRxActivityEth0Get**](docs/MonitoringApi.md#appliancemonitoringnetrxactivityeth0get) | **GET** /appliance/monitoring/net.rx.activity.eth0 | Detailsfor:netRXeth0
*MonitoringApi* | [**ApplianceMonitoringQueryGet**](docs/MonitoringApi.md#appliancemonitoringqueryget) | **GET** /appliance/monitoring/query | Querystatsfor:neteth0
*NetworkingApi* | [**ApplianceNetworkingDnsDomainsGet**](docs/NetworkingApi.md#appliancenetworkingdnsdomainsget) | **GET** /appliance/networking/dns/domains | Domains
*NetworkingApi* | [**ApplianceNetworkingDnsDomainsPost**](docs/NetworkingApi.md#appliancenetworkingdnsdomainspost) | **POST** /appliance/networking/dns/domains | Domainsadd
*NetworkingApi* | [**ApplianceNetworkingDnsDomainsPut**](docs/NetworkingApi.md#appliancenetworkingdnsdomainsput) | **PUT** /appliance/networking/dns/domains | Domainsset
*NetworkingApi* | [**ApplianceNetworkingDnsHostnameGet**](docs/NetworkingApi.md#appliancenetworkingdnshostnameget) | **GET** /appliance/networking/dns/hostname | Hostname
*NetworkingApi* | [**ApplianceNetworkingDnsHostnamePut**](docs/NetworkingApi.md#appliancenetworkingdnshostnameput) | **PUT** /appliance/networking/dns/hostname | Hostname-set
*NetworkingApi* | [**ApplianceNetworkingDnsHostnameTestPost**](docs/NetworkingApi.md#appliancenetworkingdnshostnametestpost) | **POST** /appliance/networking/dns/hostname/test | Hostname-test
*NetworkingApi* | [**ApplianceNetworkingDnsServersGet**](docs/NetworkingApi.md#appliancenetworkingdnsserversget) | **GET** /appliance/networking/dns/servers | DNSservers
*NetworkingApi* | [**ApplianceNetworkingDnsServersPost**](docs/NetworkingApi.md#appliancenetworkingdnsserverspost) | **POST** /appliance/networking/dns/servers | DNSservers-add
*NetworkingApi* | [**ApplianceNetworkingDnsServersPut**](docs/NetworkingApi.md#appliancenetworkingdnsserversput) | **PUT** /appliance/networking/dns/servers | DNSservers-set
*NetworkingApi* | [**ApplianceNetworkingDnsServersTestPost**](docs/NetworkingApi.md#appliancenetworkingdnsserverstestpost) | **POST** /appliance/networking/dns/servers/test | DNSservers-test
*NetworkingApi* | [**ApplianceNetworkingInterfacesGet**](docs/NetworkingApi.md#appliancenetworkinginterfacesget) | **GET** /appliance/networking/interfaces | Interfaces
*NetworkingApi* | [**ApplianceNetworkingInterfacesNic0Get**](docs/NetworkingApi.md#appliancenetworkinginterfacesnic0get) | **GET** /appliance/networking/interfaces/nic0 | Interface-details
*RecoveryApi* | [**ApplianceRecoveryBackupJobByApplianceBackupjobIdGet**](docs/RecoveryApi.md#appliancerecoverybackupjobbyappliancebackupjobidget) | **GET** /appliance/recovery/backup/job/{appliance_backupjob_id} | Backupjob-status
*RecoveryApi* | [**ApplianceRecoveryBackupJobCancelByApplianceBackupjobIdPost**](docs/RecoveryApi.md#appliancerecoverybackupjobcancelbyappliancebackupjobidpost) | **POST** /appliance/recovery/backup/job/{appliance_backupjob_id}/cancel | Backupjob-cancel
*RecoveryApi* | [**ApplianceRecoveryBackupJobDetailsGet**](docs/RecoveryApi.md#appliancerecoverybackupjobdetailsget) | **GET** /appliance/recovery/backup/job/details | Backupjob-details
*RecoveryApi* | [**ApplianceRecoveryBackupJobGet**](docs/RecoveryApi.md#appliancerecoverybackupjobget) | **GET** /appliance/recovery/backup/job | Backupjob
*RecoveryApi* | [**ApplianceRecoveryBackupJobPost**](docs/RecoveryApi.md#appliancerecoverybackupjobpost) | **POST** /appliance/recovery/backup/job | Backupjob-create
*RecoveryApi* | [**ApplianceRecoveryBackupPartsByBackupPartsIdGet**](docs/RecoveryApi.md#appliancerecoverybackuppartsbybackuppartsidget) | **GET** /appliance/recovery/backup/parts/{backup-parts-id} | Backupparts-sizeofspecficpart
*RecoveryApi* | [**ApplianceRecoveryBackupPartsGet**](docs/RecoveryApi.md#appliancerecoverybackuppartsget) | **GET** /appliance/recovery/backup/parts | Backupparts
*RecoveryApi* | [**ApplianceRecoveryBackupSchedulesByBackupScheduleIdDelete**](docs/RecoveryApi.md#appliancerecoverybackupschedulesbybackupscheduleiddelete) | **DELETE** /appliance/recovery/backup/schedules/{backup-schedule-id} | Backupschedule-remove
*RecoveryApi* | [**ApplianceRecoveryBackupSchedulesByBackupScheduleIdGet**](docs/RecoveryApi.md#appliancerecoverybackupschedulesbybackupscheduleidget) | **GET** /appliance/recovery/backup/schedules/{backup-schedule-id} | Backupschedule-details
*RecoveryApi* | [**ApplianceRecoveryBackupSchedulesByBackupScheduleIdPost**](docs/RecoveryApi.md#appliancerecoverybackupschedulesbybackupscheduleidpost) | **POST** /appliance/recovery/backup/schedules/{backup-schedule-id} | Backupschedule-create
*RecoveryApi* | [**ApplianceRecoveryBackupSchedulesByBackupScheduleIdPut**](docs/RecoveryApi.md#appliancerecoverybackupschedulesbybackupscheduleidput) | **PUT** /appliance/recovery/backup/schedules/{backup-schedule-id} | Backupschedule-update
*RecoveryApi* | [**ApplianceRecoveryBackupSchedulesGet**](docs/RecoveryApi.md#appliancerecoverybackupschedulesget) | **GET** /appliance/recovery/backup/schedules | Backupschedule
*RecoveryApi* | [**ApplianceRecoveryBackupValidatePost**](docs/RecoveryApi.md#appliancerecoverybackupvalidatepost) | **POST** /appliance/recovery/backup/validate | Backupjob-validate
*RecoveryApi* | [**ApplianceRecoveryRestoreJobCancelPost**](docs/RecoveryApi.md#appliancerecoveryrestorejobcancelpost) | **POST** /appliance/recovery/restore/job/cancel | Restorejob-cancel
*RecoveryApi* | [**ApplianceRecoveryRestoreJobGet**](docs/RecoveryApi.md#appliancerecoveryrestorejobget) | **GET** /appliance/recovery/restore/job | Restorejob
*RecoveryApi* | [**ApplianceRecoveryRestoreJobPost**](docs/RecoveryApi.md#appliancerecoveryrestorejobpost) | **POST** /appliance/recovery/restore/job | Restorejob-create
*SystemApi* | [**ApplianceSystemStorageGet**](docs/SystemApi.md#appliancesystemstorageget) | **GET** /appliance/system/storage | Storage
*SystemApi* | [**ApplianceSystemStorageResizePost**](docs/SystemApi.md#appliancesystemstorageresizepost) | **POST** /appliance/system/storage/resize | Storage-resize
*SystemApi* | [**ApplianceSystemTimeGet**](docs/SystemApi.md#appliancesystemtimeget) | **GET** /appliance/system/time | Time
*SystemApi* | [**ApplianceSystemUptimeGet**](docs/SystemApi.md#appliancesystemuptimeget) | **GET** /appliance/system/uptime | Uptime
*SystemApi* | [**ApplianceSystemVersionGet**](docs/SystemApi.md#appliancesystemversionget) | **GET** /appliance/system/version | Version
*TechpreviewFirewallApi* | [**ApplianceTechpreviewNetworkingFirewallAddrInboundDeletePost**](docs/TechpreviewFirewallApi.md#appliancetechpreviewnetworkingfirewalladdrinbounddeletepost) | **POST** /appliance/techpreview/networking/firewall/addr/inbound/delete | Deleterule
*TechpreviewFirewallApi* | [**ApplianceTechpreviewNetworkingFirewallAddrInboundGet**](docs/TechpreviewFirewallApi.md#appliancetechpreviewnetworkingfirewalladdrinboundget) | **GET** /appliance/techpreview/networking/firewall/addr/inbound | Listinboundrules
*TechpreviewFirewallApi* | [**ApplianceTechpreviewNetworkingFirewallAddrInboundPost**](docs/TechpreviewFirewallApi.md#appliancetechpreviewnetworkingfirewalladdrinboundpost) | **POST** /appliance/techpreview/networking/firewall/addr/inbound | Createrule
*TechpreviewFirewallApi* | [**ApplianceTechpreviewNetworkingFirewallAddrInboundPut**](docs/TechpreviewFirewallApi.md#appliancetechpreviewnetworkingfirewalladdrinboundput) | **PUT** /appliance/techpreview/networking/firewall/addr/inbound | Replaceallrules
*TechpreviewIPv4Api* | [**ApplianceTechpreviewNetworkingIpv4Get**](docs/TechpreviewIPv4Api.md#appliancetechpreviewnetworkingipv4get) | **GET** /appliance/techpreview/networking/ipv4 | IPv4
*TechpreviewIPv4Api* | [**ApplianceTechpreviewNetworkingIpv4GetPost**](docs/TechpreviewIPv4Api.md#appliancetechpreviewnetworkingipv4getpost) | **POST** /appliance/techpreview/networking/ipv4/get | IPv4-details
*TechpreviewIPv4Api* | [**ApplianceTechpreviewNetworkingIpv4Post**](docs/TechpreviewIPv4Api.md#appliancetechpreviewnetworkingipv4post) | **POST** /appliance/techpreview/networking/ipv4 | IPv4-set
*TechpreviewIPv4Api* | [**ApplianceTechpreviewNetworkingIpv4RenewPost**](docs/TechpreviewIPv4Api.md#appliancetechpreviewnetworkingipv4renewpost) | **POST** /appliance/techpreview/networking/ipv4/renew | IPv4-renew
*TechpreviewIPv6Api* | [**ApplianceTechpreviewNetworkingIpv6Get**](docs/TechpreviewIPv6Api.md#appliancetechpreviewnetworkingipv6get) | **GET** /appliance/techpreview/networking/ipv6 | IPv6
*TechpreviewIPv6Api* | [**ApplianceTechpreviewNetworkingIpv6GetPost**](docs/TechpreviewIPv6Api.md#appliancetechpreviewnetworkingipv6getpost) | **POST** /appliance/techpreview/networking/ipv6/get | IPv6-details
*TechpreviewIPv6Api* | [**ApplianceTechpreviewNetworkingIpv6Post**](docs/TechpreviewIPv6Api.md#appliancetechpreviewnetworkingipv6post) | **POST** /appliance/techpreview/networking/ipv6 | IPv6-set
*TechpreviewLocalaccountsApi* | [**ApplianceTechpreviewLocalAccountsUserByApplianceLocalUserGet**](docs/TechpreviewLocalaccountsApi.md#appliancetechpreviewlocalaccountsuserbyappliancelocaluserget) | **GET** /appliance/techpreview/local-accounts/user/{appliance_local_user} | Localaccounts-details
*TechpreviewLocalaccountsApi* | [**ApplianceTechpreviewLocalAccountsUserGet**](docs/TechpreviewLocalaccountsApi.md#appliancetechpreviewlocalaccountsuserget) | **GET** /appliance/techpreview/local-accounts/user | Localaccounts
*TechpreviewLocalaccountsApi* | [**ApplianceTechpreviewLocalAccountsUserPost**](docs/TechpreviewLocalaccountsApi.md#appliancetechpreviewlocalaccountsuserpost) | **POST** /appliance/techpreview/local-accounts/user | Localaccounts-create
*TechpreviewLocalaccountsApi* | [**ApplianceTechpreviewLocalAccountsUserPut**](docs/TechpreviewLocalaccountsApi.md#appliancetechpreviewlocalaccountsuserput) | **PUT** /appliance/techpreview/local-accounts/user | Localaccounts-update
*TechpreviewLocalaccountsApi* | [**ApplianceTechpreviewLocalAccountsUserTestDelete**](docs/TechpreviewLocalaccountsApi.md#appliancetechpreviewlocalaccountsusertestdelete) | **DELETE** /appliance/techpreview/local-accounts/user/test | Localaccounts-remove
*TechpreviewMonitoringApi* | [**ApplianceTechpreviewMonitoringSnmpDisablePost**](docs/TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmpdisablepost) | **POST** /appliance/techpreview/monitoring/snmp/disable | DisableSNMP
*TechpreviewMonitoringApi* | [**ApplianceTechpreviewMonitoringSnmpEnablePost**](docs/TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmpenablepost) | **POST** /appliance/techpreview/monitoring/snmp/enable | EnableSNMP
*TechpreviewMonitoringApi* | [**ApplianceTechpreviewMonitoringSnmpGet**](docs/TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmpget) | **GET** /appliance/techpreview/monitoring/snmp | SNMPconfiguration
*TechpreviewMonitoringApi* | [**ApplianceTechpreviewMonitoringSnmpHashPost**](docs/TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmphashpost) | **POST** /appliance/techpreview/monitoring/snmp/hash | Generatehash
*TechpreviewMonitoringApi* | [**ApplianceTechpreviewMonitoringSnmpLimitsGet**](docs/TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmplimitsget) | **GET** /appliance/techpreview/monitoring/snmp/limits | GetSNMPlimits
*TechpreviewMonitoringApi* | [**ApplianceTechpreviewMonitoringSnmpPost**](docs/TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmppost) | **POST** /appliance/techpreview/monitoring/snmp | SetSNMPconfiguration
*TechpreviewMonitoringApi* | [**ApplianceTechpreviewMonitoringSnmpResetPost**](docs/TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmpresetpost) | **POST** /appliance/techpreview/monitoring/snmp/reset | SNMPfactorysettings
*TechpreviewMonitoringApi* | [**ApplianceTechpreviewMonitoringSnmpStatsGet**](docs/TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmpstatsget) | **GET** /appliance/techpreview/monitoring/snmp/stats | SNMPStats
*TechpreviewMonitoringApi* | [**ApplianceTechpreviewMonitoringSnmpTestPost**](docs/TechpreviewMonitoringApi.md#appliancetechpreviewmonitoringsnmptestpost) | **POST** /appliance/techpreview/monitoring/snmp/test | TestSNMP
*TechpreviewNTPApi* | [**ApplianceTechpreviewNtpGet**](docs/TechpreviewNTPApi.md#appliancetechpreviewntpget) | **GET** /appliance/techpreview/ntp | Configurationstatus
*TechpreviewNTPApi* | [**ApplianceTechpreviewNtpServerDeletePost**](docs/TechpreviewNTPApi.md#appliancetechpreviewntpserverdeletepost) | **POST** /appliance/techpreview/ntp/server/delete | NTP-deleteserver
*TechpreviewNTPApi* | [**ApplianceTechpreviewNtpServerPost**](docs/TechpreviewNTPApi.md#appliancetechpreviewntpserverpost) | **POST** /appliance/techpreview/ntp/server | NTP-addserver
*TechpreviewNTPApi* | [**ApplianceTechpreviewNtpServerPut**](docs/TechpreviewNTPApi.md#appliancetechpreviewntpserverput) | **PUT** /appliance/techpreview/ntp/server | NTP-setservers
*TechpreviewNTPApi* | [**ApplianceTechpreviewNtpTestPost**](docs/TechpreviewNTPApi.md#appliancetechpreviewntptestpost) | **POST** /appliance/techpreview/ntp/test | NTP-test
*TechpreviewPoweroperationsApi* | [**ApplianceTechpreviewShutdownCancelPost**](docs/TechpreviewPoweroperationsApi.md#appliancetechpreviewshutdowncancelpost) | **POST** /appliance/techpreview/shutdown/cancel | Shutdown-cancel
*TechpreviewPoweroperationsApi* | [**ApplianceTechpreviewShutdownGet**](docs/TechpreviewPoweroperationsApi.md#appliancetechpreviewshutdownget) | **GET** /appliance/techpreview/shutdown | Shutdownoperations
*TechpreviewPoweroperationsApi* | [**ApplianceTechpreviewShutdownPoweroffPost**](docs/TechpreviewPoweroperationsApi.md#appliancetechpreviewshutdownpoweroffpost) | **POST** /appliance/techpreview/shutdown/poweroff | Shutdown
*TechpreviewPoweroperationsApi* | [**ApplianceTechpreviewShutdownRestartPost**](docs/TechpreviewPoweroperationsApi.md#appliancetechpreviewshutdownrestartpost) | **POST** /appliance/techpreview/shutdown/restart | Restart
*TechpreviewProxyApi* | [**ApplianceTechpreviewNetworkingProxyDeletePost**](docs/TechpreviewProxyApi.md#appliancetechpreviewnetworkingproxydeletepost) | **POST** /appliance/techpreview/networking/proxy/delete | Proxy-delete
*TechpreviewProxyApi* | [**ApplianceTechpreviewNetworkingProxyGet**](docs/TechpreviewProxyApi.md#appliancetechpreviewnetworkingproxyget) | **GET** /appliance/techpreview/networking/proxy | Getproxyconfigurations
*TechpreviewProxyApi* | [**ApplianceTechpreviewNetworkingProxyPut**](docs/TechpreviewProxyApi.md#appliancetechpreviewnetworkingproxyput) | **PUT** /appliance/techpreview/networking/proxy | Proxy-set
*TechpreviewProxyApi* | [**ApplianceTechpreviewNetworkingProxyTestPost**](docs/TechpreviewProxyApi.md#appliancetechpreviewnetworkingproxytestpost) | **POST** /appliance/techpreview/networking/proxy/test | Proxy-test
*TechpreviewRoutesApi* | [**ApplianceTechpreviewNetworkingRoutesDeletePost**](docs/TechpreviewRoutesApi.md#appliancetechpreviewnetworkingroutesdeletepost) | **POST** /appliance/techpreview/networking/routes/delete | Routes-delete
*TechpreviewRoutesApi* | [**ApplianceTechpreviewNetworkingRoutesGet**](docs/TechpreviewRoutesApi.md#appliancetechpreviewnetworkingroutesget) | **GET** /appliance/techpreview/networking/routes | List
*TechpreviewRoutesApi* | [**ApplianceTechpreviewNetworkingRoutesPost**](docs/TechpreviewRoutesApi.md#appliancetechpreviewnetworkingroutespost) | **POST** /appliance/techpreview/networking/routes | Routes-add
*TechpreviewRoutesApi* | [**ApplianceTechpreviewNetworkingRoutesPut**](docs/TechpreviewRoutesApi.md#appliancetechpreviewnetworkingroutesput) | **PUT** /appliance/techpreview/networking/routes | Set
*TechpreviewRoutesApi* | [**ApplianceTechpreviewNetworkingRoutesTestPost**](docs/TechpreviewRoutesApi.md#appliancetechpreviewnetworkingroutestestpost) | **POST** /appliance/techpreview/networking/routes/test | Routes-test
*TechpreviewServicesApi* | [**ApplianceTechpreviewServicesControlPost**](docs/TechpreviewServicesApi.md#appliancetechpreviewservicescontrolpost) | **POST** /appliance/techpreview/services/control | Services-control
*TechpreviewServicesApi* | [**ApplianceTechpreviewServicesGet**](docs/TechpreviewServicesApi.md#appliancetechpreviewservicesget) | **GET** /appliance/techpreview/services | Services
*TechpreviewServicesApi* | [**ApplianceTechpreviewServicesRestartPost**](docs/TechpreviewServicesApi.md#appliancetechpreviewservicesrestartpost) | **POST** /appliance/techpreview/services/restart | Services-restart
*TechpreviewServicesApi* | [**ApplianceTechpreviewServicesStatusGetPost**](docs/TechpreviewServicesApi.md#appliancetechpreviewservicesstatusgetpost) | **POST** /appliance/techpreview/services/status/get | Services-getspecificservicedetails
*TechpreviewServicesApi* | [**ApplianceTechpreviewServicesStopPost**](docs/TechpreviewServicesApi.md#appliancetechpreviewservicesstoppost) | **POST** /appliance/techpreview/services/stop | Services-stop
*TechpreviewSystemupdatesApi* | [**ApplianceTechpreviewSystemUpdateGet**](docs/TechpreviewSystemupdatesApi.md#appliancetechpreviewsystemupdateget) | **GET** /appliance/techpreview/system/update | System-update
*TechpreviewSystemupdatesApi* | [**ApplianceTechpreviewSystemUpdatePost**](docs/TechpreviewSystemupdatesApi.md#appliancetechpreviewsystemupdatepost) | **POST** /appliance/techpreview/system/update | System-updaterepository
*TechpreviewTimesyncApi* | [**ApplianceTechpreviewTimesyncGet**](docs/TechpreviewTimesyncApi.md#appliancetechpreviewtimesyncget) | **GET** /appliance/techpreview/timesync | Timesync
*TechpreviewTimesyncApi* | [**ApplianceTechpreviewTimesyncPut**](docs/TechpreviewTimesyncApi.md#appliancetechpreviewtimesyncput) | **PUT** /appliance/techpreview/timesync | Timesync-set
*VmonApi* | [**ApplianceVmonServiceContentLibraryGet**](docs/VmonApi.md#appliancevmonservicecontentlibraryget) | **GET** /appliance/vmon/service/content-library | Getdetailsaboutspecificservice
*VmonApi* | [**ApplianceVmonServiceContentLibraryPatch**](docs/VmonApi.md#appliancevmonservicecontentlibrarypatch) | **PATCH** /appliance/vmon/service/content-library | Updatespecificservice
*VmonApi* | [**ApplianceVmonServiceContentLibraryRestartPost**](docs/VmonApi.md#appliancevmonservicecontentlibraryrestartpost) | **POST** /appliance/vmon/service/content-library/restart | Restartspecificservice
*VmonApi* | [**ApplianceVmonServiceContentLibraryStartPost**](docs/VmonApi.md#appliancevmonservicecontentlibrarystartpost) | **POST** /appliance/vmon/service/content-library/start | Startspecificservice
*VmonApi* | [**ApplianceVmonServiceContentLibraryStopPost**](docs/VmonApi.md#appliancevmonservicecontentlibrarystoppost) | **POST** /appliance/vmon/service/content-library/stop | Stopspecificservice
*VmonApi* | [**ApplianceVmonServiceGet**](docs/VmonApi.md#appliancevmonserviceget) | **GET** /appliance/vmon/service | Services


<a name="documentation-for-models"></a>
## Documentation for Models

 - [IO.Swagger.Model.Address](docs/Address.md)
 - [IO.Swagger.Model.BackupjobCreateRequest](docs/BackupjobCreateRequest.md)
 - [IO.Swagger.Model.BackupjobValidateRequest](docs/BackupjobValidateRequest.md)
 - [IO.Swagger.Model.BackupscheduleCreateRequest](docs/BackupscheduleCreateRequest.md)
 - [IO.Swagger.Model.BackupscheduleRunRequest](docs/BackupscheduleRunRequest.md)
 - [IO.Swagger.Model.BackupscheduleUpdateRequest](docs/BackupscheduleUpdateRequest.md)
 - [IO.Swagger.Model.Config](docs/Config.md)
 - [IO.Swagger.Model.Config10](docs/Config10.md)
 - [IO.Swagger.Model.Config11](docs/Config11.md)
 - [IO.Swagger.Model.Config12](docs/Config12.md)
 - [IO.Swagger.Model.Config13](docs/Config13.md)
 - [IO.Swagger.Model.Config14](docs/Config14.md)
 - [IO.Swagger.Model.Config15](docs/Config15.md)
 - [IO.Swagger.Model.Config2](docs/Config2.md)
 - [IO.Swagger.Model.Config3](docs/Config3.md)
 - [IO.Swagger.Model.Config4](docs/Config4.md)
 - [IO.Swagger.Model.Config5](docs/Config5.md)
 - [IO.Swagger.Model.Config6](docs/Config6.md)
 - [IO.Swagger.Model.Config7](docs/Config7.md)
 - [IO.Swagger.Model.Config8](docs/Config8.md)
 - [IO.Swagger.Model.Configlist](docs/Configlist.md)
 - [IO.Swagger.Model.ConsoleCLIDisableRequest](docs/ConsoleCLIDisableRequest.md)
 - [IO.Swagger.Model.ConsoleCLIEnableRequest](docs/ConsoleCLIEnableRequest.md)
 - [IO.Swagger.Model.CreateruleRequest](docs/CreateruleRequest.md)
 - [IO.Swagger.Model.DCUIDisableRequest](docs/DCUIDisableRequest.md)
 - [IO.Swagger.Model.DCUIEnableRequest](docs/DCUIEnableRequest.md)
 - [IO.Swagger.Model.DNSserversAddRequest](docs/DNSserversAddRequest.md)
 - [IO.Swagger.Model.DNSserversSetRequest](docs/DNSserversSetRequest.md)
 - [IO.Swagger.Model.DNSserversTestRequest](docs/DNSserversTestRequest.md)
 - [IO.Swagger.Model.DeleteruleRequest](docs/DeleteruleRequest.md)
 - [IO.Swagger.Model.DomainsaddRequest](docs/DomainsaddRequest.md)
 - [IO.Swagger.Model.DomainssetRequest](docs/DomainssetRequest.md)
 - [IO.Swagger.Model.GeneratehashRequest](docs/GeneratehashRequest.md)
 - [IO.Swagger.Model.HostnameSetRequest](docs/HostnameSetRequest.md)
 - [IO.Swagger.Model.HostnameTestRequest](docs/HostnameTestRequest.md)
 - [IO.Swagger.Model.IPv4DetailsRequest](docs/IPv4DetailsRequest.md)
 - [IO.Swagger.Model.IPv4SetRequest](docs/IPv4SetRequest.md)
 - [IO.Swagger.Model.IPv6SetRequest](docs/IPv6SetRequest.md)
 - [IO.Swagger.Model.LocalaccountsCreateRequest](docs/LocalaccountsCreateRequest.md)
 - [IO.Swagger.Model.LocalaccountsUpdateRequest](docs/LocalaccountsUpdateRequest.md)
 - [IO.Swagger.Model.NTPAddserverRequest](docs/NTPAddserverRequest.md)
 - [IO.Swagger.Model.NTPDeleteserverRequest](docs/NTPDeleteserverRequest.md)
 - [IO.Swagger.Model.NTPSetserversRequest](docs/NTPSetserversRequest.md)
 - [IO.Swagger.Model.NTPTestRequest](docs/NTPTestRequest.md)
 - [IO.Swagger.Model.Piece](docs/Piece.md)
 - [IO.Swagger.Model.Piece2](docs/Piece2.md)
 - [IO.Swagger.Model.ProxyDeleteRequest](docs/ProxyDeleteRequest.md)
 - [IO.Swagger.Model.ProxySetRequest](docs/ProxySetRequest.md)
 - [IO.Swagger.Model.ProxyTestRequest](docs/ProxyTestRequest.md)
 - [IO.Swagger.Model.RecurrenceInfo](docs/RecurrenceInfo.md)
 - [IO.Swagger.Model.ReplaceallrulesRequest](docs/ReplaceallrulesRequest.md)
 - [IO.Swagger.Model.RestartRequest](docs/RestartRequest.md)
 - [IO.Swagger.Model.RestorejobCreateRequest](docs/RestorejobCreateRequest.md)
 - [IO.Swagger.Model.RetentionInfo](docs/RetentionInfo.md)
 - [IO.Swagger.Model.Route](docs/Route.md)
 - [IO.Swagger.Model.RoutesAddRequest](docs/RoutesAddRequest.md)
 - [IO.Swagger.Model.RoutesDeleteRequest](docs/RoutesDeleteRequest.md)
 - [IO.Swagger.Model.RoutesTestRequest](docs/RoutesTestRequest.md)
 - [IO.Swagger.Model.Rule](docs/Rule.md)
 - [IO.Swagger.Model.SSHDisableRequest](docs/SSHDisableRequest.md)
 - [IO.Swagger.Model.SSHEnableRequest](docs/SSHEnableRequest.md)
 - [IO.Swagger.Model.ServicesControlRequest](docs/ServicesControlRequest.md)
 - [IO.Swagger.Model.ServicesGetspecificservicedetailsRequest](docs/ServicesGetspecificservicedetailsRequest.md)
 - [IO.Swagger.Model.ServicesRestartRequest](docs/ServicesRestartRequest.md)
 - [IO.Swagger.Model.ServicesStopRequest](docs/ServicesStopRequest.md)
 - [IO.Swagger.Model.SetRequest](docs/SetRequest.md)
 - [IO.Swagger.Model.SetSNMPconfigurationRequest](docs/SetSNMPconfigurationRequest.md)
 - [IO.Swagger.Model.ShellDisableRequest](docs/ShellDisableRequest.md)
 - [IO.Swagger.Model.ShellEnableRequest](docs/ShellEnableRequest.md)
 - [IO.Swagger.Model.ShutdownRequest](docs/ShutdownRequest.md)
 - [IO.Swagger.Model.Spec](docs/Spec.md)
 - [IO.Swagger.Model.Spec2](docs/Spec2.md)
 - [IO.Swagger.Model.SystemUpdaterepositoryRequest](docs/SystemUpdaterepositoryRequest.md)
 - [IO.Swagger.Model.TimesyncSetRequest](docs/TimesyncSetRequest.md)
 - [IO.Swagger.Model.UpdatespecificserviceRequest](docs/UpdatespecificserviceRequest.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="auth"></a>
### auth

- **Type**: HTTP basic authentication
