import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpModule } from '@angular/http';
import { TranslateModule } from '@ngx-translate/core';

import { CoreModule } from '@app/core';
import { SharedModule } from '@app/shared';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { QuoteService } from './quote.service';
import { FrmsService } from '@app/home/frms.service';

@NgModule({
  imports: [
    CommonModule,
    TranslateModule,
    CoreModule,
    SharedModule,
    HomeRoutingModule,
    HttpModule
  ],
  declarations: [
    HomeComponent
  ],
  providers: [
    FrmsService,
    QuoteService,
    { provide: 'BASE_URL', useFactory: getBaseUrl }
  ]
})
export class HomeModule { }

export function getBaseUrl() {
  return document.getElementsByTagName('base')[0].href;
}

