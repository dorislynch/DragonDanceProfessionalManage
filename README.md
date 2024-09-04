
# react-native-dragon-dance-professional-manage

## Getting started

`$ npm install react-native-dragon-dance-professional-manage --save`

### Mostly automatic installation

`$ react-native link react-native-dragon-dance-professional-manage`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-dragon-dance-professional-manage` and add `RNDragonDanceProfessionalManage.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNDragonDanceProfessionalManage.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNDragonDanceProfessionalManagePackage;` to the imports at the top of the file
  - Add `new RNDragonDanceProfessionalManagePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-dragon-dance-professional-manage'
  	project(':react-native-dragon-dance-professional-manage').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-dragon-dance-professional-manage/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-dragon-dance-professional-manage')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNDragonDanceProfessionalManage.sln` in `node_modules/react-native-dragon-dance-professional-manage/windows/RNDragonDanceProfessionalManage.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Dragon.Dance.Professional.Manage.RNDragonDanceProfessionalManage;` to the usings at the top of the file
  - Add `new RNDragonDanceProfessionalManagePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNDragonDanceProfessionalManage from 'react-native-dragon-dance-professional-manage';

// TODO: What to do with the module?
RNDragonDanceProfessionalManage;
```
  