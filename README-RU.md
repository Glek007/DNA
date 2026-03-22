# 🧬 Генератор ДНК

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=FFFFFF)](https://dotnet.microsoft.com/download/dotnet-framework)
[![C#](https://img.shields.io/badge/C%23-10-239120?style=for-the-badge&logo=csharp&logoColor=FFFFFF)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Console](https://img.shields.io/badge/Console-App-2D2D2D?style=for-the-badge&logo=windowsterminal&logoColor=FFFFFF)](https://en.wikipedia.org/wiki/Console_application)
[![License](https://img.shields.io/badge/License-MIT-2D2D2D?style=for-the-badge&logo=opensourceinitiative&logoColor=FFFFFF)](LICENSE)

[![Made with Love](https://img.shields.io/badge/Сделано%20с-❤️-FF69B4?style=for-the-badge)](https://github.com/Glek007/DNA)

## Languages
[![EN](https://img.shields.io/badge/README-EN-2D2D2D?style=for-the-badge&logo=github&logoColor=FFFFFF)](./README.md)
[![RU](https://img.shields.io/badge/README-RU-2D2D2D?style=for-the-badge&logo=google-translate&logoColor=FFFFFF)](./README-RU.md)

---

## 📖 О проекте

**Генератор ДНК** — это простая, но визуально приятная программа, которая создаёт случайную последовательность ДНК на основе заданной вами длины. Каждый нуклеотид (A, T, G, C) отображается своим уникальным цветом, что делает вывод не только полезным, но и увлекательным!

Программа идеально подходит для:
- Изучения азотистых оснований ДНК
- Быстрой генерации случайных строк
- Демонстрации работы с цветом в консоли на C#

---

## ✨ Возможности

| | Функция | Описание |
|---|---------|-------------|
| 🎨 | **Цветной вывод** | Каждый нуклеотид получает свой цвет: A=Зелёный, T=Красный, G=Жёлтый, C=Синий |
| 🧬 | **Случайная последовательность** | Генерирует случайные ДНК-строки с использованием встроенного класса `Random` |
| 💾 | **Автосохранение** | Автоматически сохраняет сгенерированную последовательность в файл `dna_result.txt` на рабочем столе |
| 🔢 | **Ввод пользователя** | Вы можете указать точное количество нуклеотидов для генерации |
| 🖥️ | **Простой консольный интерфейс** | Чистый, понятный интерфейс |

---

## 🚀 Начало работы

### Системные требования

- Операционная система Windows
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472) или новее
- Visual Studio 2017+ (необязательно, только для редактирования)

### Установка

1. Клонируйте репозиторий или скачайте исходный код:
```bash
git clone https://github.com/Glek007/DNA.git
```

2. Откройте файл `DNA 1.0.0.csproj` в Visual Studio

3. Соберите и запустите проект (нажмите `F5`)

### Быстрый старт

Запустите программу и введите число, когда появится запрос:

```
Введите длину текста: 20
```

Программа отобразит цветную ДНК-последовательность и сохранит её на рабочий стол:

```
Результат:
AGCTTCGATAGCTAGCCTAG
Файл сохранен: C:\Users\...\Desktop\dna_result.txt
```

---

## 🎮 Как это работает

```csharp
char[] nucleotides = { 'A', 'T', 'G', 'C' };
var random = new Random();

// Генерация случайного нуклеотида
char symbol = nucleotides[random.Next(nucleotides.Length)];

// Цвет в зависимости от типа нуклеотида
switch (symbol)
{
    case 'A': Console.ForegroundColor = ConsoleColor.Green; break;
    case 'T': Console.ForegroundColor = ConsoleColor.Red; break;
    case 'G': Console.ForegroundColor = ConsoleColor.Yellow; break;
    case 'C': Console.ForegroundColor = ConsoleColor.Blue; break;
}
```

Последовательность строится символ за символом, отображается в цвете, а затем сохраняется как обычный текстовый файл.

---

## 📁 Результат

После каждого запуска на вашем рабочем столе создаётся файл `dna_result.txt`, содержащий «сырую» строку ДНК (без цветовых кодов, просто обычный текст).

Пример содержимого:
```
AGCTTCGATAGCTAGCCTAG
```

---

## 🛠️ Структура проекта

```
DNA/
├── Program.cs              # Основная логика приложения
├── DNA 1.0.0.csproj        # Файл проекта
├── free-icon-helix-4149254-_1_.ico  # Иконка приложения
├── App.config              # Файл конфигурации
└── README.md               # Этот файл
```

---

## 🤝 Участие в разработке

Это небольшой проект для обучения, но вы можете:
- Предложить улучшения
- Добавить новые функции (например, форматы файлов, больше нуклеотидов и т.д.)
- Сообщить об ошибках

Открывайте issue или отправляйте pull request!

---

## 📄 Лицензия

Проект распространяется под лицензией **MIT** — подробности см. в файле [LICENSE](LICENSE).

---

## 🧪 Идеи для развития

- [ ] Поддержка пользовательских наборов нуклеотидов
- [ ] Экспорт в форматы CSV или FASTA
- [ ] Генерация комплементарной цепи (обратной цепи)
- [ ] Сохранение в выбранное пользователем место
- [ ] Генерация нескольких последовательностей за раз

---

## 💬 Обратная связь

Если у вас есть вопросы или вы просто хотите поздороваться, свяжитесь со мной!
Сделано с ❤️ [Glek007](https://github.com/Glek007)
