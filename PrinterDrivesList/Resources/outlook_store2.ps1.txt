##
# Begin Script
##

# Create Outlook object
$Outlook = New-Object -ComObject Outlook.Application
$stores = $Outlook.Session.Stores
$accounts = $outlook.session.accounts

# Basic information
"Current profile has the following configured accounts:"
$dn = @{label = "Account Type"; expression={$_.displayname}}
$un = @{label = "User Name"; expression = {$_.username}}
$sm = @{label = "SMTP Address"; expression = {$_.smtpaddress}}
$accounts | Format-Table -AutoSize $dn,$un,$sm

# Check number of stores > 0
if ($stores.Count -le 0) {"No stores found"; return}

# Outlook Off-Line folder store
$ost = $stores | where{$_.filepath -match ".ost$"}
if (!$ost)
 {
   "No Outlook Offline Folder store found"
 }
else
 {
   "Exchange Offline Folder Store:"
   $ost | ft filepath -HideTableHeaders
  }

# PST Files
$pst = $stores | where {$_.filepath -match ".pst$"}
if (!$pst)
  {
    "No PST files found"
  }
else
  {
    "PST Files"
    $dn = @{label = "Display Name"; expression={$_.displayname}}
    $fn = @{label = "File Path"; expression={$_.filepath}}
    $pst | ft $dn,$fn       
  }
# End Script  