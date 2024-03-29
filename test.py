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

roblox_player_beta_folder = find_roblox_player_beta_folder()
microsoft_folder = find_microsoft_roblox_player_beta_folder()

if roblox_player_beta_folder:
    print("Folder containing RobloxPlayerBeta.exe:", roblox_player_beta_folder)
if microsoft_folder:
    print("Folder containing Windows10Universal.exe:", microsoft_folder)
if not roblox_player_beta_folder and not microsoft_folder:
    print("Roblox player folders not found.")
