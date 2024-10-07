>Diller/Languages [Türkçe](#türkçe) / [English](#english)
# Türkçe
# Password Management App
Bu uygulama, şifrelerinizi güvenli bir şekilde saklamanıza ve yönetmenize olanak tanır. Firebase ve AES şifreleme kullanılarak kullanıcı verileri güvenli bir şekilde depolanır ve şifrelenir.

## İçindekiler
- [Özellikler](#özellikler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Çalışma Mantığı](#çalışma-mantığı)
- [Bilinen Sorunlar](#bilinen-sorunlar)
- [Gereksinimler](#gereksinimler)

## Özellikler
- **Kullanıcı Yönetimi:** Giriş yapma, kayıt olma ve kullanıcı kayıtlarını yönetme.

- **Şifre Saklama:** Platformlar için güçlü parolalar üretme ve saklama.

- **Şifre Oluşturma:** Kişiselleştirilebilir güçlü parolalar oluşturma.

- **Veri Şifreleme:** AES-256 ile girilen tüm kayıt bilelerini şifrelenmiş olarak güvenli bir şekilde saklama.

- **Metin Hashing:** SHA-256 ile verilen metnin hash değerini hesaplama.

- **Firebase Entegrasyonu:** Verilerin Firebase kullanılarak depolama.


## Kurulum
**Depoyu Klonlayın**
```
git clone https://github.com/suleymanakin/PasswordManagementApp.git
cd PasswordManagementApp
```

- **Gereksinimleri Yükleyin**

***(Bu projede .NET Core 5.0 veya daha yeni bir sürüm gereklidir. Ayrıca, aşağıdaki NuGet paketleri kullanılmıştır:)***

- ```FirebaseAdmin``` Firebase Admin SDK. (Firebase ile etkileşim kurmak için kullanılır.)
- ```Google.Apis.Auth``` Google API kimlik doğrulaması. (Google API kimlik doğrulama işlemleri için kullanılır.)
- ```Newtonsoft.Json``` JSON verileri ile çalışmak için. (JSON verilerini serileştirmek ve deserialize etmek için kullanılır.)


**Firebase Yapılandırması**
Firebase Admin SDK JSON dosyasını UserFiles klasörüne yerleştirin. Dosya adı uygulma içinde gerekli yerlere uzantısı verilmeli. Bu dosya, Firebase ile etkileşim kurmak için gereklidir.

**Şifreleme Anahtarı Oluşturma**
Uygulamayı ilk kez çalıştırdığınızda, şifreleme için gerekli olan SecretKey.json dosyasını oluşturmanız gerekecek. Bu dosya, AES şifreleme ve şifre çözme işlemleri için gereklidir. ***Settings*** menüsü, bu dosyayı oluşturmanıza yardımcı olur.

## Kullanım
1. Uygulamayı Başlatın
2. Giriş Yapın (Hesabınız yoksa Kayıt olun) (Test Hesabı: mail=test@test.com parola=123456)
3. Home menüsünden Şifre ekleyebilir yada görüntüleyebilirsiniz. Güncelleme ve silme işlemleri ***List Passwords*** üzerinden yapılır.
4. Şifre Oluşturma ve Saklama
5. Şifre Güncelleme ve Silme
6. Ayarlar ve Bilgi

## Çalışma Mantığı
- Firebase Entegrasyonu: Kullanıcı verileri ve şifreler Firebase kullanılarak saklanır ve yönetilir. Firebase Admin SDK, veritabanına erişimi sağlar.
- Şifreleme: Kullanıcı şifreleri AES-256 algoritması ile şifrelenir. Şifreleme anahtarı ve IV değerleri SecretKey.json dosyasına kaydedilir ve gerektiğinde yüklenir.
- Kullanıcı Arayüzü: Windows Forms kullanılarak oluşturulmuş bir kullanıcı arayüzü ile kullanıcı etkileşimi sağlanır.

## Bilinen Sorunlar
- İnternet Bağlantısı: Uygulama Firebase ile iletişim kurmak için internet bağlantısı gerektirir. Bağlantı yoksa, uygulama başlamaz.
- Dosya Yolu: JSON dosya yolları, farklı sistemlerde çalışabilir. Yolu kendi sisteminize göre güncellemeniz gerekebilir.
- Şifreleme Anahtarı: SecretKey.json dosyası oluşturulmadan uygulama çalışmaz(Settings menüsünden oluşturulur.)

## Gereksinimler
- Windows İşletim Sistemi
- [Kurulum](#kurulum)'da yer alan gereksinimler içerisindeki kütüphaneler.


# English
# Password Management App
This app allows you to securely store and manage your passwords. User data is securely stored and encrypted using Firebase and AES encryption.

## Contents
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Working Logic](#working-logic)
- [Known Issues](#known-issues)
- [Requirements](#requirements)

## Features
- **User Management:** Log in, register, and manage user records.

- **Password Storage:** Generate and store strong passwords for platforms.

- **Password Generation:** Create customizable strong passwords.

- **Data Encryption:** Securely store all entered registration information with AES-256 encryption.

- **Text Hashing:** Calculating the hash value of the given text with SHA-256.

- **Firebase Integration:** Storing data using Firebase.

## Installation
**Clone the Repository**
```
git clone https://github.com/suleymanakin/PasswordManagementApp.git
cd PasswordManagementApp
```

- **Install Requirements**

***(This project requires .NET Core 5.0 or later. Additionally, the following NuGet packages were used:)***

- ```FirebaseAdmin``` Firebase Admin SDK. (Used to interact with Firebase.)
- ```Google.Apis.Auth``` Google API authentication. (Used for Google API authentication.)
- ```Newtonsoft.Json``` To work with JSON data. (Used to serialize and deserialize JSON data.)

**Firebase Configuration**
Place the Firebase Admin SDK JSON file in the UserFiles folder. The file name should be given an extension in the required places in the application. This file is required to interact with Firebase.

**Creating the Encryption Key**
When you run the application for the first time, you will need to create the SecretKey.json file required for encryption. This file is required for AES encryption and decryption operations. The ***Settings*** menu helps you create this file.

## Usage
1. Start the application
2. Log in (Register if you do not have an account) (Test Account: mail=test@test.com password=123456)
3. You can add or view passwords from the Home menu. Update and delete operations are done via ***List Passwords***.
4. Creating and Storing Passwords
5. Updating and Deleting Passwords
6. Settings and Information

## Working Logic
- Firebase Integration: User data and passwords are stored and managed using Firebase. Firebase Admin SDK provides access to the database.
- Encryption: User passwords are encrypted with the AES-256 algorithm. The encryption key and IV values ​​are saved in the SecretKey.json file and loaded when necessary.
- User Interface: User interaction is provided with a user interface created using Windows Forms.

## Known Issues
- Internet Connection: The application requires an internet connection to communicate with Firebase. If there is no connection, the application will not start.
- File Path: JSON file paths may work on different systems. You may need to update the path according to your system.
- Encryption Key: The application will not run without the SecretKey.json file being created (created from the Settings menu.)

## Requirements
- Windows Operating System
- Libraries in the requirements in [Installation](#installation).
