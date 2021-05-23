# IOOFI

### Powershell Administrator

Install chocolately (https://chocolatey.org/install)
```
Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))
```

Check chocolately is installed
```
choco
```

Install Virtuall box
```
cinst virtualbox -Version 6.0.16 -y
```

Install Vagrant and restart computer 
```
cinst vagrant -Version 2.2.13 -y
Restart-Computer
```

Install Ubuntu
```
mkdir ~\vagrant\ubuntu64_18
cd ~\vagrant\ubuntu64_18
vagrant box add ubuntu/bionic64 --box-version 20200130.1.0
vagrant init ubuntu/bionic64
```

Start Ubuntu (start virtual machine)
```
vagrant up
```

Install Rlogin (ssh client)
```
cinst rlogin -y
```

Check SSH info
```
vagrant up 
vagrant ssh-config
```

Example info
```
Host default
  HostName 127.0.0.1
  User vagrant
  Port 2222
  UserKnownHostsFile /dev/null
  StrictHostKeyChecking no
  PasswordAuthentication no
  IdentityFile C:/Users/progedu/vagrant/ubuntu64_18/.vagrant/machines/default/virtualbox/private_key
  IdentitiesOnly yes
  LogLevel FATAL
```
Take note `User` and `Port`

Start Rlogin
```
rlogin
```

Create New Server (New(N))
+ Entry : vagrant
+ Protocol : ssh
+ Host Name（Server IP Adress）: localhost
+ TCP Port `Port`
+ `Login User` : `User`
+ SSH authentication : `%USERPROFILE%\vagrant\ubuntu64_18\.vagrant\machines\default\virtualbox\private_key`
+ character encoding :UTF-8

Double Click -> OK
