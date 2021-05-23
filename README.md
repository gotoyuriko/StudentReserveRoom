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

### How to open Ubuntu ???
1. Powershell Administrator
```
cd ~\vagrant\ubuntu64_18
vagrant up
rlogin
```
1. Rlogin select server

### How to end Ubuntu?
Rlogin
```
exit
```
Powershell Administrator
```
vagrant halt
exit
```

### Synchronise Local Files with Ubuntu's Files
```
cd ~\vagrant\ubuntu64_18
mkdir workspace
```
Open .vagrantfile 

Around Line 47 add 
```
# config.vm.synced_folder "../data", "/vagrant_data"
config.vm.synced_folder "./workspace", "/home/vagrant/workspace"
```
Around Line 55-61
```
  # config.vm.provider "virtualbox" do |vb|
  #   # Display the VirtualBox GUI when booting the machine
  #   vb.gui = true
  #
  #   # Customize the amount of memory on the VM:
  #   vb.memory = "1024"
  # end
```
Uncomment like this velow
```
  config.vm.provider "virtualbox" do |vb|
  #   # Display the VirtualBox GUI when booting the machine
  #   vb.gui = true
  #
  #   # Customize the amount of memory on the VM:
    vb.memory = "1024"
  end
```

.vagrantfile you can compare uncommented lines
```
# -*- mode: ruby -*-
# vi: set ft=ruby :

# All Vagrant configuration is done below. The "2" in Vagrant.configure
# configures the configuration version (we support older styles for
# backwards compatibility). Please don't change it unless you know what
# you're doing.
Vagrant.configure("2") do |config|
  # The most common configuration options are documented and commented below.
  # For a complete reference, please see the online documentation at
  # https://docs.vagrantup.com.

  # Every Vagrant development environment requires a box. You can search for
  # boxes at https://vagrantcloud.com/search.
  config.vm.box = "ubuntu/bionic64"

  # Disable automatic box update checking. If you disable this, then
  # boxes will only be checked for updates when the user runs
  # `vagrant box outdated`. This is not recommended.
  # config.vm.box_check_update = false

  # Create a forwarded port mapping which allows access to a specific port
  # within the machine from a port on the host machine. In the example below,
  # accessing "localhost:8080" will access port 80 on the guest machine.
  # NOTE: This will enable public access to the opened port
  # config.vm.network "forwarded_port", guest: 80, host: 8080

  # Create a forwarded port mapping which allows access to a specific port
  # within the machine from a port on the host machine and only allow access
  # via 127.0.0.1 to disable public access
  # config.vm.network "forwarded_port", guest: 80, host: 8080, host_ip: "127.0.0.1"

  # Create a private network, which allows host-only access to the machine
  # using a specific IP.
  # config.vm.network "private_network", ip: "192.168.33.10"

  # Create a public network, which generally matched to bridged network.
  # Bridged networks make the machine appear as another physical device on
  # your network.
  # config.vm.network "public_network"

  # Share an additional folder to the guest VM. The first argument is
  # the path on the host to the actual folder. The second argument is
  # the path on the guest to mount the folder. And the optional third
  # argument is a set of non-required options.
  # config.vm.synced_folder "../data", "/vagrant_data"
  config.vm.synced_folder "./workspace", "/home/vagrant/workspace"
  # Provider-specific configuration so you can fine-tune various
  # backing providers for Vagrant. These expose provider-specific options.
  # Example for VirtualBox:
  #
  config.vm.provider "virtualbox" do |vb|
  #   # Display the VirtualBox GUI when booting the machine
  #   vb.gui = true
  #
  #   # Customize the amount of memory on the VM:
    vb.memory = "1024"
  end
  #
  # View the documentation for the provider you are using for more
  # information on available options.

  # Enable provisioning with a shell script. Additional provisioners such as
  # Puppet, Chef, Ansible, Salt, and Docker are also available. Please see the
  # documentation for more information about their specific syntax and use.
  # config.vm.provision "shell", inline: <<-SHELL
  #   apt-get update
  #   apt-get install -y apache2
  # SHELL
end
```

Reload Ubuntu
```
cd ~\vagrant\ubuntu64_18
vagrant reload --provision
```

### Install Git
```
cd ~\vagrant\ubuntu64_18
vagrant up
rlogin 
git
```
In case `Command 'git' not found`
```
sudo apt update
sudo apt install git
```

Create ssh private-key and public key (Rlogin)
```
ssh-keygen
```
Check ssh private-key and public key (Rlogin)
```
ls ~/.ssh
```

