﻿$categoryId = "cca079fb-38a6-4258-498f-08dd57314208"

$products = @(
    @{ name = "Hakkon Şarjlı Matkap"; price = 1200.0; stock = 15 },
    @{ name = "Bosch Profesyonel Matkap"; price = 2200.0; stock = 10 },
    @{ name = "Einhell Akülü Vidalama"; price = 900.0; stock = 25 },
    @{ name = "Stanley El Aleti Seti"; price = 750.0; stock = 30 },
    @{ name = "Dewalt Darbeli Matkap"; price = 1800.0; stock = 12 },
    @{ name = "Makita Avuç Taşlama"; price = 1600.0; stock = 8 },
    @{ name = "Hitachi Şarjlı Tornavida"; price = 1100.0; stock = 20 },
    @{ name = "Hilti Beton Kırıcı"; price = 4500.0; stock = 5 },
    @{ name = "Black & Decker Zımpara"; price = 950.0; stock = 18 },
    @{ name = "Ryobi Dekupaj Testere"; price = 1400.0; stock = 22 },
    @{ name = "Festool Freze Makinesi"; price = 3000.0; stock = 7 },
    @{ name = "Metabo Akülü Matkap"; price = 1300.0; stock = 16 },
    @{ name = "Milwaukee Darbeli Somun Sıkıcı"; price = 2700.0; stock = 9 },
    @{ name = "Craftsman Çekiç Seti"; price = 400.0; stock = 40 },
    @{ name = "Bauhaus Ahşap Testeresi"; price = 850.0; stock = 12 },
    @{ name = "Tekzen Elektrikli Tornavida"; price = 550.0; stock = 35 },
    @{ name = "İzeltaş Anahtar Takımı"; price = 2000.0; stock = 14 },
    @{ name = "Gedore Lokma Seti"; price = 2500.0; stock = 11 },
    @{ name = "SATA Pense Seti"; price = 650.0; stock = 28 },
    @{ name = "İnce İşçilik Maket Bıçağı"; price = 150.0; stock = 50 }
)

$logFile = "C:\Temp\api_log.txt"
New-Item -Path $logFile -ItemType File -Force | Out-Null 

foreach ($product in $products) {
    $jsonBody = @{
        name = $product.name
        price = $product.price
        stock = $product.stock
        categoryId = $categoryId
    } | ConvertTo-Json -Depth 10

    Write-Output "Adding Product: $($product.name)"
    $jsonBody | Out-File -FilePath $logFile -Append 

    try {
        $response = Invoke-WebRequest -Uri "http://localhost:5084/api/Products/add" `
            -Method Post `
            -Headers @{ "Accept" = "application/json"; "Content-Type" = "application/json" } `
            -Body $jsonBody

        Write-Output "Added: $($product.name) - Status: $($response.StatusCode)"
    }
    catch {
        Write-Output "Error adding: $($product.name) - $($_.Exception.Message)"
        $_.Exception.Response | Out-File -FilePath $logFile -Append  
    }

    Start-Sleep -Milliseconds 500
}

Write-Output "Tüm ürünler başarıyla eklendi!"
