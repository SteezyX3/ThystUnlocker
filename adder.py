import os
import json
from json import loads
from requests import get as HttpGet
from getpass import getuser
import winreg
from pathlib import Path

def find_roblox_player_beta_folder():
    try:
        key = winreg.OpenKey(winreg.HKEY_CURRENT_USER, r"SOFTWARE\ROBLOX Corporation\Environments\roblox-player", 0, winreg.KEY_READ)
        version, _ = winreg.QueryValueEx(key, "version")
        winreg.CloseKey(key)
        version = version if isinstance(version, str) else version.decode()
        roblox_player_beta_path = Path(get_local_app_data_path()) / "Roblox" / "Versions" / version / "RobloxPlayerBeta.exe"
        if roblox_player_beta_path.exists():
            return roblox_player_beta_path.parent
        else:
            return None
    except FileNotFoundError:
        return None

def find_microsoft_roblox_player_beta_folder():
    try:
        key = winreg.OpenKey(winreg.HKEY_CURRENT_USER, r"SOFTWARE\ROBLOX Corporation\Environments\roblox-player", 0, winreg.KEY_READ)
        version, _ = winreg.QueryValueEx(key, "version")
        winreg.CloseKey(key)
        version = version if isinstance(version, str) else version.decode()
        microsoft_roblox_player_beta_path = Path(get_local_app_data_path()) / "Roblox" / "Versions" / version / "Windows10Universal.exe"
        if microsoft_roblox_player_beta_path.exists():
            return microsoft_roblox_player_beta_path.parent
        else:
            return None
    except FileNotFoundError:
        return None
    
def get_local_app_data_path():
    return Path.home() / "AppData" / "Local"



############ THIS IS THE ROBLOX FPS UNLOCKER WHICH CONNECTS TO THE C# APP, PLEASE DO NOT EDIT NOTHING UNLESS YOU KNOW WHAT YOU'RE DOING
############ PLEASE DON'T CLAIM THIS APP AS YOURS
############ MC STANDS FOR MICROSOFT
############ WEB STANDS FOR THE ROBLOX WEBSITE VERSION SINCE THEYRE 2 DIFFERENT THINGS



mcR = True
webR = True

current_dir = os.path.dirname(os.path.abspath(__file__))
MicrosoftVersionRequest = HttpGet("https://clientsettingscdn.roblox.com/v1/client-version/WindowsStudio64")
WebVersionRequest = HttpGet("https://clientsettingscdn.roblox.com/v1/client-version/WindowsPlayer")

def get_current_disk_partition():
    current_directory = os.getcwd()
    current_drive = current_directory.split(":")[0].upper() + ":"
    return current_drive

current_disk_partition = get_current_disk_partition()

if MicrosoftVersionRequest and WebVersionRequest:
    MCrbxvers = loads(MicrosoftVersionRequest.text)["clientVersionUpload"]
    Webrbxvers = loads(WebVersionRequest.text)["clientVersionUpload"]
    print("Current Microsoft Roblox Version:", MCrbxvers, "Current Website Roblox Version:", Webrbxvers)
    settings_file_path = os.path.join(current_dir, 'settings.json')
    if os.path.exists(settings_file_path):
        print("Found settings.json at:", settings_file_path, "which you can edit if you want to get the desired fps")
        with open(settings_file_path, 'r') as file:
            file_content = file.read().strip()
            if not file_content:
                default_settings = {"fpsTarget": {"DFIntTaskSchedulerTargetFps": 144}}
                with open(settings_file_path, 'w') as default_file:
                    json.dump(default_settings, default_file, indent=4)
                    print("settings.json was empty. Default settings added.")
            else:
                try:
                    settings_data = json.loads(file_content)
                    print("Settings data:")
                    print(settings_data)
                    fps_target_value = settings_data.get("fpsTarget", {}).get("DFIntTaskSchedulerTargetFps")
                    if fps_target_value is not None:
                        print("Found DFIntTaskSchedulerTargetFps value:", fps_target_value)
                        
                        # For Microsoft version
                        MCroblox_client = find_microsoft_roblox_player_beta_folder()
                        if MCroblox_client is None:
                            print("Roblox Microsoft version doesn't exist so skipping.")
                            mcR = False
                        else:
                            MCclient_settings_folder = os.path.join(MCroblox_client, 'ClientSettings')
                            MCclient_settings_file_path = os.path.join(MCclient_settings_folder, 'ClientAppSettings.json')
                            if not os.path.exists(MCclient_settings_file_path) or not os.path.exists(MCclient_settings_folder):
                                os.makedirs(MCclient_settings_folder)
                                print("ClientSettings folder created for Microsoft version")
                                client_settings_data = {"DFIntTaskSchedulerTargetFps": fps_target_value}
                                with open(MCclient_settings_file_path, 'w') as client_file:
                                    json.dump(client_settings_data, client_file, indent=4)
                                    print("Microsoft version: ClientAppSettings.json has DFIntTaskSchedulerTargetFps:", fps_target_value)
                            else:
                                client_settings_data = {"DFIntTaskSchedulerTargetFps": fps_target_value}
                                with open(MCclient_settings_file_path, 'w') as client_file:
                                    json.dump(client_settings_data, client_file, indent=4)
                                    print("Microsoft version: ClientAppSettings.json has DFIntTaskSchedulerTargetFps:", fps_target_value)
                    
                        # For Web version
                        WEBroblox_client = find_roblox_player_beta_folder()
                        
                        if not os.path.exists(WEBroblox_client):
                           webR = False
                           print("Roblox Website version doesn't exist so skipping.")
                        else:
                            WEBclient_settings_folder = os.path.join(WEBroblox_client, 'ClientSettings')
                            WEBclient_settings_file_path = os.path.join(WEBclient_settings_folder, 'ClientAppSettings.json')
                            if not os.path.exists(WEBclient_settings_file_path) or not os.path.exists(WEBclient_settings_folder):
                                 os.makedirs(WEBclient_settings_folder)
                                 print("ClientSettings folder created for Website vearsion")
                                 client_settings_data = {"DFIntTaskSchedulerTargetFps": fps_target_value}
                                 with open(WEBclient_settings_file_path, 'w') as client_file:
                                    json.dump(client_settings_data, client_file, indent=4)
                                    print("Microsoft version: ClientAppSettings.json has DFIntTaskSchedulerTargetFps:", fps_target_value)
                            else:
                                client_settings_data = {"DFIntTaskSchedulerTargetFps": fps_target_value}
                                with open(WEBclient_settings_file_path, 'w') as client_file:
                                    json.dump(client_settings_data, client_file, indent=4)
                                    print("Microsoft version: ClientAppSettings.json has DFIntTaskSchedulerTargetFps:", fps_target_value)

                        if mcR and webR == False:
                            mcR == True
                            webR == True
                            print("No roblox found. Nothing was edited")
                        else:
                            print("You can close this app if you only needed to unlock FPS")
                            print("Make sure to unlock the fps everytime roblox updates")
                except json.JSONDecodeError:
                           print("settings.json is not in valid JSON format.")
    else:
        print("settings.json not found in the same directory. Please create one with the following name (settings.json) or redownload")
else:
    print("Unable to fetch Roblox version.")
