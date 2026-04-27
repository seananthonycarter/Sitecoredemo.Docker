import { Placeholder } from '@sitecore-jss/sitecore-jss-nextjs';
import { ComponentProps } from 'lib/component-props';
import React from 'react';

const EventsMain = (props: ComponentProps): JSX.Element => {
  return (
    <div className={`flex flex-col`}>
      <section className={'exclude-margin mb-[24px] xl:mb-[40px]'}>
        <Placeholder name={`eventsheader`} rendering={props.rendering} />
      </section>
      <section>
        <Placeholder name={`eventslisting`} rendering={props.rendering} />
      </section>
      <section>
        <Placeholder name={`eventsmain`} rendering={props.rendering} />
      </section>
    </div>
  );
};

export default EventsMain;
