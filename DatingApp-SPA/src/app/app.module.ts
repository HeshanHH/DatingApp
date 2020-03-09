import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';

import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';
import { from } from 'rxjs';

@NgModule({
   declarations: [
      AppComponent,
      ValueComponent // whenever u create a componet it automatically added to ng module and also added to import.
   ],
   imports: [
      BrowserModule,
      HttpClientModule // you have to bring this on and also import it.
   ],
   providers: [],
   bootstrap: [
      AppComponent// inhereappComponetisbootstraped.
   ]
})
export class AppModule { }
