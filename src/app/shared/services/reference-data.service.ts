import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';
import { map, catchError } from 'rxjs/operators';
import { FilingRequestStatus } from '@app/home/filing-request-status.interface';

@Injectable()
export class ReferenceDataService {

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getFilingRequestStauses(): Observable<FilingRequestStatus[]> {
    return this.httpClient
      .cache()
      .get(this.baseUrl + '/webapi/api/referencedata/getfilingrequeststatuses')
      .pipe(
        map((body: any) => body.value),
        catchError(() => of('Error, loading filing request stauses.'))
      );
  }

}
